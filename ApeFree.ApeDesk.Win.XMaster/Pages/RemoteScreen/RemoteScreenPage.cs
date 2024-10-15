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

namespace ApeFree.ApeDesk.Win.XMaster.Pages
{
    public partial class RemoteScreenPage : UserControl, IPage
    {
        private readonly GlobalSettings settings;

        public string PageTitle => "Remote Screen";

        public Image PageIcon => Resources.Img_Desk;

        private RemoteScreenPage()
        {
            InitializeComponent();
        }

        public RemoteScreenPage(ApeRpc.IService[] services, GlobalSettings settings) : this()
        {
            foreach (ApeRpc.IService service in services)
            {
                var rsc = new RemoteScreenControl(service, settings.GetSlaveSettings(service.ServiceName));
                rsc.Parent = glp;
            }

            this.settings = settings;
        }
    }
}
