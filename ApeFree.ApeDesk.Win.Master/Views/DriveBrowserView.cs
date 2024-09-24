using ApeFree.ApeDesk.Core;
using ApeFree.ApeForms.Forms.Notifications;
using ApeFree.ApeRpc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApeFree.ApeDesk.Win.Master
{
    public partial class DriveBrowserView : UserControl
    {
        public IDriveBrowser DriveBrowser { get; private set; }
        public IProcessManager ProcessManager { get; private set; }

        private Stack<string> history = new Stack<string>();

        public DriveBrowserView()
        {
            InitializeComponent();
            listView.AllowDrop = true;
        }

        public void Bind(IService service)
        {
            if (service is IDriveBrowser driveBrowser)
            {
                DriveBrowser = driveBrowser;
            }

            if (service is IProcessManager processManager)
            {
                ProcessManager = processManager;
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            OpenRmoteFolder(tbPath.Text);
        }

        private void OpenRmoteFolder(string path)
        {
            Task.Run(() =>
            {
                var items = DriveBrowser.GetFileCatalog(path);
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

                    if (!history.Any() || history.Peek() != path)
                    {
                        history.Push(path);
                    }

                    listView.Items.Clear();
                    if (lvis.Any())
                    {
                        listView.Items.AddRange(lvis);
                    }
                });
            });
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listView.HitTest(e.X, e.Y);
            if (hitTest.Item == null)
            {
                return;
            }

            var item = (FileCatalogItem)hitTest.Item.Tag;
            var dir = history.Peek();

            if (item.IsDirectory)
            {
                dir = Path.Combine(dir, item.Name);
                OpenRmoteFolder(dir);
            }
            else
            {
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
                    s.Options.Add(new NotificationOption("打开文件", (_, arg) => Process.Start(localFilePath)));
                    s.Options.Add(new NotificationOption("打开目录", (_, arg) => OpenExplorer(localFilePath)));
                });
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
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
                    OpenFileContextMenu(item);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (history.Count <= 1)
            {
                return;
            }

            history.Pop();
            var path = history.Peek();
            tbPath.Text = path;
            OpenRmoteFolder(path);
        }

        private void btnDrive_Click(object sender, EventArgs e)
        {
            var dis = DriveBrowser.GetDrives();
            cmsDrives.Items.Clear();

            var arr = dis.Select(x => new ToolStripMenuItem(x.Name, null, (_, arg) => OpenRmoteFolder(x.RootDirectory))).ToArray();
            cmsDrives.Items.AddRange(arr);

            cmsDrives.Show(btnDrive, new Point(0, btnDrive.Height));
        }

        private void OpenFileContextMenu(FileCatalogItem item)
        {
            var extension = Path.GetExtension(item.Name);

            cmsFileContextMenu.Items.Clear();

            var dir = history.Peek();
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

        private static void OpenExplorer(string filePath)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = $"/select, \"{filePath}\""
            });
        }

        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    var fileName = Path.GetFileName(file);
                    var remoteFilePath = Path.Combine(tbPath.Text, fileName);
                    UploadFile(remoteFilePath, file);
                }
                OpenRmoteFolder(tbPath.Text);
            }
        }

        private void UploadFile(string remoteFilePath, string localFilePath)
        {
            var data = File.ReadAllBytes(localFilePath);
            DriveBrowser.SaveFile(remoteFilePath, data);
        }

        private void DownloadFile(string remoteFilePath, string localFilePath, int size)
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
}
