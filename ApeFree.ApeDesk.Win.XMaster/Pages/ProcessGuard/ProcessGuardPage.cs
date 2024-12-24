using ApeFree.ApeDesk.Core;
using ApeFree.ApeDesk.Win.XMaster.Pages.RemoteScreen;
using ApeFree.ApeDesk.Win.XMaster.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.ProcessGuard
{
    public partial class ProcessGuardPage : UserControl, IPage
    {
        private readonly GlobalSettings settings;

        public string PageTitle => "Process Guard";

        public Image PageIcon => Resources.Img_Guard;

        private List<ProcessGuardItem> Items = new List<ProcessGuardItem>();

        private ProcessGuardPage()
        {
            InitializeComponent();
        }

        public ProcessGuardPage(IDeskModule[] modules, GlobalSettings settings) : this()
        {
            foreach (var item in modules)
            {
                var rsc = new ProcessGuardItem(item, settings.GetSlaveSettings(item.ModuleName));
                rsc.Parent = glp;
                Items.Add(rsc);
            }

            this.settings = settings;
        }

        private void btnLaunchAll_Click(object sender, EventArgs e)
        {
            Items.Where(x => x.IsMonitoring).ForEach(x => x.Launch());
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            Items.Where(x => x.IsMonitoring).ForEach(x => x.Shutdown());
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            Items.ForEach(x => x.IsMonitoring = true);
        }

        private void btnInverseSelection_Click(object sender, EventArgs e)
        {
            Items.ForEach(x => x.IsMonitoring = !x.IsMonitoring);
        }
    }
}
