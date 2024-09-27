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

namespace ApeFree.ApeDesk.Win.XMaster.Pages
{
    public partial class RemoteScreenPage : UserControl, IPage
    {
        public string PageTitle => "Remote Screen";

        public Image PageIcon => null;

        private RemoteScreenPage()
        {
            InitializeComponent();
        }

        public RemoteScreenPage(ApeRpc.IService[] services) : this()
        {
            foreach (ApeRpc.IService service in services)
            {
                var rsc = new RemoteScreenControl(service);
                rsc.Parent = glp;
            }
        }
    }
}
