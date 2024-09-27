using ApeFree.ApeDesk.Win.XMaster.Pages.RemoteScreen;
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
        public string PageTitle => "Process Guard";

        public Image PageIcon => null;

        private ProcessGuardPage()
        {
            InitializeComponent();
        }

        public ProcessGuardPage(ApeRpc.IService[] services) : this()
        {
            foreach (ApeRpc.IService service in services)
            {
                var rsc = new ProcessGuardItem(service);
                rsc.Parent = glp;
            }
        }
    }
}
