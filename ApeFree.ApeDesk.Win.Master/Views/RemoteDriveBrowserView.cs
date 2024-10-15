using ApeFree.ApeDesk.Core;
using ApeFree.ApeForms.Core.Controls.Views;
using ApeFree.ApeForms.Forms.Notifications;
using ApeFree.ApeRpc;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.Master
{
    public class RemoteDriveBrowserView : DriveBrowserView
    {
        /// <summary>
        /// 驱动浏览器
        /// </summary>
        public IDriveBrowser DriveBrowser { get; private set; }

        public virtual void Bind(IService service)
        {
            if (service is IDriveBrowser driveBrowser)
            {
                DriveBrowser = driveBrowser;
            }
        }

        public override void OpenFolder(string path)
        {
            Task.Run(() =>
            {
                var items = DriveBrowser.GetFileCatalog(path, DisplayItemType == DisplayItemType.OnlyFolder, SearchPattern);

                var lvis = items.Select(item =>
                {
                    ListViewItem lvi = new ListViewItem(item.Name);

                    if (item.IsDirectory)
                    {
                        lvi.ImageKey = "Folder";
                    }
                    else
                    {
                        lvi.SubItems.Add(item.FileSize.ToString());
                        lvi.SubItems.Add(item.CreationTime.ToString());
                        lvi.ImageKey = "File";
                    }
                    lvi.Tag = item;
                    return lvi;
                }).ToArray();

                listView.ModifyInUI(() =>
                {
                    tbPath.Text = path;

                    if (!HistoryStack.Any() || HistoryStack.Peek() != path)
                    {
                        HistoryStack.Push(path);
                    }

                    listView.Items.Clear();
                    if (lvis.Any())
                    {
                        listView.Items.AddRange(lvis);
                    }
                });
            });
        }

        protected override void OnDriveButtonClicked(object sender, EventArgs e)
        {
            var dis = DriveBrowser.GetDrives();
            cmsDrives.Items.Clear();

            var arr = dis.Select(x => new ToolStripMenuItem(x.Name, null, (_, arg) => OpenFolder(x.RootDirectory))).ToArray();
            cmsDrives.Items.AddRange(arr);

            cmsDrives.Show(btnDrive, new Point(0, btnDrive.Height));
        }

        protected override void OnFileDragDrop(object sender, DragEventArgs e)
        {
            if (!AllowDrop)
            {
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    var fileName = Path.GetFileName(file);
                    var remoteFilePath = Path.Combine(CurrentPath, fileName);
                    UploadFile(remoteFilePath, file);
                }
                OpenFolder(CurrentPath);
            }
        }

        protected override void OnFileItemMouseClicked(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listView.HitTest(e.X, e.Y);
            if (hitTest.Item == null)
            {
                return;
            }

            var item = (FileCatalogItem)hitTest.Item.Tag;

            if (e.Button == MouseButtons.Right)
            {
                if (item.IsDirectory)
                {

                }
                else
                {
                    OpenFileContextMenu(cmsFileContextMenu, item);
                }
            }
        }

        protected override void OnListViewMouseDoubleClicked(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listView.HitTest(e.X, e.Y);
            if (hitTest.Item == null)
            {
                return;
            }

            var item = (FileCatalogItem)hitTest.Item.Tag;
            var dir = HistoryStack.Peek();

            if (item.IsDirectory)
            {
                dir = Path.Combine(dir, item.Name);
                OpenFolder(dir);
            }
            else
            {
                OnFileItemDoubleClicked(dir, item, hitTest);
            }
        }

        /// <summary>
        /// 上传文件到远程文件夹
        /// </summary>
        /// <param name="remoteFilePath">远程文件路径</param>
        /// <param name="localFilePath">本地文件路径</param>
        protected virtual void UploadFile(string remoteFilePath, string localFilePath)
        {
            var data = File.ReadAllBytes(localFilePath);
            DriveBrowser.SaveFile(remoteFilePath, data);
        }

        /// <summary>
        /// 下载远程文件到本地
        /// </summary>
        /// <param name="remoteFilePath">远程文件路径</param>
        /// <param name="localFilePath">本地文件路径</param>
        /// <param name="size">文件字节数</param>
        protected virtual void DownloadFile(string remoteFilePath, string localFilePath, int size)
        {
            if (File.Exists(localFilePath))
            {
                File.Delete(localFilePath);
            }

            var packSize = 1024 * 512;
            var packCount = (int)Math.Ceiling(size / (float)packSize);

            using (var fs = File.OpenWrite(localFilePath))
            {
                for (int i = 0; i < packCount; i++)
                {
                    var data = DriveBrowser.ReadFile(remoteFilePath, i * packSize, packSize);
                    fs.Write(data, 0, data.Length);
                }
            }
        }
    }

    public class RemoteDriveManagementView : RemoteDriveBrowserView
    {
        /// <summary>
        /// 进程管理器
        /// </summary>
        public IProcessManager ProcessManager { get; private set; }

        public RemoteDriveManagementView()
        {
            AllowDrop = true;

            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFileDragDrop);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFileDragEnter);
        }

        public override void Bind(IService service)
        {
            base.Bind(service);

            if (service is IProcessManager processManager)
            {
                ProcessManager = processManager;
            }
        }

        protected override void OnFileItemDoubleClicked(string dir, object contextItem, ListViewHitTestInfo hitTest)
        {
            var item = (FileCatalogItem)contextItem;

            var remoteFilePath = Path.Combine(dir, item.Name);

            var localFolderPath = "RemoteFiles";
            var localFilePath = $"{localFolderPath}\\{item.Name}";
            Directory.CreateDirectory(localFolderPath);

            DownloadFile(remoteFilePath, localFilePath, (int)item.FileSize);

            Notification.Builder.ShowImageTextNotification(s =>
            {
                s.Title = "已获取远端文件";
                s.Message = $"{item.Name} 已存放至 {localFilePath}";
                s.Image = imageList.Images[hitTest.Item.ImageKey];
                s.Options.Add(new NotificationOption("打开文件", (_, arg) => OpenLocalFile(localFilePath)));
                s.Options.Add(new NotificationOption("打开目录", (_, arg) => OpenExplorer(localFilePath)));
            });
        }

        /// <summary>
        /// 打开本地文件
        /// </summary>
        /// <param name="localFilePath"></param>
        /// <exception cref="Exception"></exception>
        protected virtual void OpenLocalFile(string localFilePath)
        {
            try
            {
                Process.Start(localFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"无法打开本地文件 '{localFilePath}', 原因：{ex.Message}", ex);
            }
        }

        /// <inheritdoc/>
        protected override void OpenFileContextMenu(ContextMenuStrip cmsFileContextMenu, object contextItem)
        {
            var item = (FileCatalogItem)contextItem;

            var extension = Path.GetExtension(item.Name);

            cmsFileContextMenu.Items.Clear();

            var dir = HistoryStack.Peek();
            var remoteFilePath = Path.Combine(dir, item.Name);
            var localFolderPath = "RemoteFiles";
            var localFilePath = $"{localFolderPath}\\{item.Name}";
            Directory.CreateDirectory(localFolderPath);

            var tsmiDownload = cmsFileContextMenu.Items.Add("下载", null, (s, e) => DownloadFile(remoteFilePath, localFilePath, (int)item.FileSize));
            var tsmiOpenLocalFile = cmsFileContextMenu.Items.Add("打开文件", null, (s, e) => Process.Start(localFilePath)).With(x => x.Enabled = File.Exists(localFilePath));
            var tsmiOpenLocalDir = cmsFileContextMenu.Items.Add("打开所在文件夹", null, (s, e) => OpenExplorer(localFilePath)).With(x => x.Enabled = File.Exists(localFilePath));
            var tsmiRemoteExecute = cmsFileContextMenu.Items.Add("远程运行", null, (s, e) => ProcessManager.StartProcess(remoteFilePath)).With(x => x.Enabled = ProcessManager != null);

            cmsFileContextMenu.Show(MousePosition);
        }

        /// <summary>
        /// 打开资源管理器
        /// </summary>
        /// <param name="filePath"></param>
        private static void OpenExplorer(string filePath)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = $"/select, \"{filePath}\""
            });
        }
    }
}
