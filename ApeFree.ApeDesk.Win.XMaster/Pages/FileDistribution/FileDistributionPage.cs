using ApeFree.ApeDesk.Core;
using ApeFree.ApeDesk.Win.XMaster.Pages.RemoteScreen;
using ApeFree.ApeDesk.Win.XMaster.Properties;
using ApeFree.ApeForms.Forms.Notifications;
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
    public partial class FileDistributionPage : UserControl, IPage
    {
        private readonly GlobalSettings settings;

        public string PageTitle => "File Distribution";

        public Image PageIcon => Resources.Img_Send;

        private List<FileDistributionItem> Items = new List<FileDistributionItem>();

        private FileDistributionPage()
        {
            InitializeComponent();
        }

        public FileDistributionPage(IDeskModule[] modules, GlobalSettings settings) : this()
        {
            foreach (var item in modules)
            {
                var fdi = new FileDistributionItem(item, settings.GetSlaveSettings(item.ModuleName));
                fdi.Parent = glp;
                Items.Add(fdi);
            }

            this.settings = settings;

            tbLocalFolder.Text = settings.Master.FileDistributionFolder;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            Items.ForEach(x => x.DistributionEnable = true);
        }

        private void btnInverseSelection_Click(object sender, EventArgs e)
        {
            Items.ForEach(x => x.DistributionEnable = !x.DistributionEnable);
        }

        private void tbLocalFolder_TextChanged(object sender, EventArgs e)
        {
            settings.Master.FileDistributionFolder = tbLocalFolder.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Toast.Show("Start sending file.");

            var localDir = tbLocalFolder.Text;
            var dirName = Path.GetFileName(localDir);
            var files = Directory.GetFiles(localDir, "*", SearchOption.AllDirectories);
            localDir = Path.GetDirectoryName(localDir);
            var headLen = localDir.Length + 1;

            Task.Run(() =>
            {
                foreach (var file in files)
                {
                    Items.Where(x => x.DistributionEnable).ForEach(x => x.SendFile(file, file.Substring(headLen)));
                }
            }).ContinueWith(t => MessageBox.Show("File sending complete."));
        }
    }
}
