using ApeFree.ApeDesk.Core;
using ApeFree.ApeDesk.Win.Master;
using ApeFree.ApeDialogs;
using ApeFree.ApeDialogs.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution
{
    public partial class FileDistributionItem : UserControl
    {
        private static ApeFormsDialogProvider dialogProvider = new ApeFormsDialogProvider();

        private readonly SlaveSettings settings;

        public override string Text { get => labServiceName.Text; set => labServiceName.Text = value; }

        /// <summary>
        /// 文件夹路径
        /// </summary>
        public string FolderPath { get => tbFolderPath.Text; set => tbFolderPath.Text = value; }

        /// <summary>
        /// 启用分发
        /// </summary>
        public bool DistributionEnable { get => cbEnable.Checked; set => cbEnable.Checked = value; }

        public IDriveBrowser DriveBrowser { get; }

        private FileDistributionItem()
        {
            InitializeComponent();
        }

        public FileDistributionItem(ApeRpc.IService service, SlaveSettings settings) : this()
        {
            Text = service.ServiceName;
            DriveBrowser = service as IDriveBrowser;
            this.settings = settings;

            FolderPath = settings.FileDistributionPath;
            DistributionEnable = settings.FileDistributionEnable;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            cbEnable.Left = 10;
            cbEnable.Top = (Height - cbEnable.Height) / 2;
        }

        private void tbFolderPath_TextChanged(object sender, EventArgs e)
        {
            settings.FileDistributionPath = tbFolderPath.Text;
        }

        private void cbEnable_CheckedChanged(object sender, EventArgs e)
        {
            settings.FileDistributionEnable = cbEnable.Checked;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var path = tbFolderPath.Text;
            if (string.IsNullOrEmpty(path))
            {
                path = "C:\\";
            }
            else
            {
                path = Path.GetDirectoryName(tbFolderPath.Text);
            }

            RemoteDriveBrowserView view = new RemoteDriveBrowserView();
            view.Bind(DriveBrowser);
            view.DisplayItemType = ApeForms.Core.Controls.Views.DisplayItemType.OnlyFolder;
            view.OpenFolder(path);

            var dialog = dialogProvider.CreateOpenFolderDialog(tbFolderPath.Text, new OpenFolderDialogSettings()
            {
                Title = "Select Folder",
                Content = "Please select the folder to receive the files.",
            }, view);
            dialog.Show();

            if (dialog.Result.IsCancel || !dialog.Result.Data.Any())
            {
                return;
            }

            tbFolderPath.Text = dialog.Result.Data.FirstOrDefault();
        }

        public void SendFile(string localFilePath, string remoteRelativePath)
        {
            var fileData = File.ReadAllBytes(localFilePath);
            var remotePath = Path.Combine(FolderPath, remoteRelativePath);
            DriveBrowser.SaveFile(remotePath, fileData);
        }
    }
}
