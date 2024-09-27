using ApeFree.ApeDesk.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution
{
    public partial class FileDistributionItem : UserControl
    {
        public override string Text { get => labServiceName.Text; set => labServiceName.Text = value; }

        /// <summary>
        /// 文件夹路径
        /// </summary>
        public string FolderPath { get => tbFolderPath.Text; set => tbFolderPath.Text = value; }

        /// <summary>
        /// 启用分发
        /// </summary>
        public bool EnableDistribution { get => cbEnable.Checked; set => cbEnable.Checked = value; }

        public IDriveBrowser DriveBrowser { get; }

        private FileDistributionItem()
        {
            InitializeComponent();
        }

        public FileDistributionItem(ApeRpc.IService service) : this()
        {
            Text = service.ServiceName;
            DriveBrowser = service as IDriveBrowser;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            cbEnable.Left = 10;
            cbEnable.Top = (Height - cbEnable.Height) / 2;
        }
    }
}
