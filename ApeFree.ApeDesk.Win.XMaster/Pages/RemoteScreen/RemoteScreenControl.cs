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

namespace ApeFree.ApeDesk.Win.XMaster.Pages.RemoteScreen
{
    public partial class RemoteScreenControl : UserControl
    {

        public override string Text { get => groupBox.Text; set => groupBox.Text = value; }

        private RemoteScreenControl()
        {
            InitializeComponent();
        }

        public RemoteScreenControl(ApeRpc.IService service) : this()
        {
            screen.Bind(service);
            Text = service.ServiceName;
        }

        private void screen_MouseEnter(object sender, EventArgs e)
        {
            screen.EnableScreenSyncing = true;
            screen.ScreenSynchronizer.ScreenKeepAlive();
        }

        private void screen_MouseLeave(object sender, EventArgs e)
        {
            screen.EnableScreenSyncing = false;
        }
    }
}
