using ApeFree.ApeDesk.Core;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.ProcessGuard
{
    public partial class ProcessGuardItem : UserControl
    {
        public override string Text { get => groupBox.Text; set => groupBox.Text = value; }

        public IProcessManager ProcessManager { get; private set; }
        public IDriveBrowser DriveBrowser { get; private set; }

        private ProcessGuardItem()
        {
            InitializeComponent();
        }

        public ProcessGuardItem(ApeRpc.IService service) : this()
        {
            Text = service.ServiceName;
            ProcessManager = service as IProcessManager;
            DriveBrowser = service as IDriveBrowser;
        }

        private void cbEnable_CheckedChanged(object sender, EventArgs e)
        {
            timerStatus.Enabled = cbEnable.Checked;

            if (!cbEnable.Checked)
            {
                return;
            }

            UpdateAppStatus();
        }

        public void UpdateAppStatus()
        {
            var path = tbPath.Text;

            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            if (!DriveBrowser.FileExists(path))
            {
                cbEnable.Checked = false;
                labStatus.Text = "Not Found";
                labStatus.ForeColor = Color.DarkRed;
                return;
            }

            if (ProcessManager.CheckProcessRunningStatus(path))
            {
                labStatus.Text = "Running";
                labStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                labStatus.Text = "Not Run";
                labStatus.ForeColor = Color.DarkRed;
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            UpdateAppStatus();
        }
    }
}
