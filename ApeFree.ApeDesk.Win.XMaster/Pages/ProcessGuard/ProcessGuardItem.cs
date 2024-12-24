using ApeFree.ApeDesk.Core;
using ApeFree.ApeDesk.Win.Master;
using ApeFree.ApeDialogs;
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
        private static ApeFormsDialogProvider dialogProvider = new ApeFormsDialogProvider();
        private readonly SlaveSettings settings;

        public override string Text { get => groupBox.Text; set => groupBox.Text = value; }

        public IProcessManager ProcessManager { get; private set; }
        public IDriveBrowser DriveBrowser { get; private set; }

        /// <summary>
        /// 是否正在监控运行状态
        /// </summary>
        public bool IsMonitoring { get => cbEnable.Checked; set => cbEnable.Checked = value; }

        private ProcessGuardItem()
        {
            InitializeComponent();
        }

        public ProcessGuardItem(IDeskModule service, SlaveSettings settings) : this()
        {
            Text = service.ModuleName;
            ProcessManager = service as IProcessManager;
            DriveBrowser = service as IDriveBrowser;
            this.settings = settings;

            cbEnable.Checked = settings.ProcessGuardEnable;
            tbPath.Text = settings.ProcessGuardPath;
        }

        private void cbEnable_CheckedChanged(object sender, EventArgs e)
        {
            timerStatus.Enabled = cbEnable.Checked;
            settings.ProcessGuardEnable = cbEnable.Checked;

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
                btnLaunch.Visible = false;
                return;
            }

            if (ProcessManager.CheckProcessRunningStatus(path))
            {
                labStatus.Text = "Running";
                labStatus.ForeColor = Color.DarkGreen;
                btnLaunch.Visible = false;
            }
            else
            {
                labStatus.Text = "Not Run";
                labStatus.ForeColor = Color.DarkRed;
                btnLaunch.Visible = true;
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            UpdateAppStatus();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var path = tbPath.Text;
            if (string.IsNullOrEmpty(path))
            {
                path = "C:\\";
            }
            else
            {
                path = Path.GetDirectoryName(tbPath.Text);
            }

            RemoteDriveBrowserView view = new RemoteDriveBrowserView();
            view.Bind(DriveBrowser);
            view.OpenFolder(path);
            view.SearchPattern = "*.exe";

            var dialog = dialogProvider.CreateOpenFileDialog(tbPath.Text, new ApeDialogs.Settings.OpenFileDialogSettings()
            {
                Title = "Select App",
                SearchPattern = "*.exe",
            }, view);
            dialog.Show();

            if (dialog.Result.IsCancel || !dialog.Result.Data.Any())
            {
                return;
            }

            tbPath.Text = dialog.Result.Data.FirstOrDefault();
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            settings.ProcessGuardPath = tbPath.Text;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Launch();
        }

        public void Launch()
        {
            var isRunning = ProcessManager.CheckProcessRunningStatus(tbPath.Text);
            if (!isRunning)
            {
                btnLaunch.Visible = false;
                labStatus.Text = "BeingStarted";
                labStatus.ForeColor = Color.Orange;
                ProcessManager.StartProcess(tbPath.Text);
            }
            cbEnable.Checked = true;
        }

        public void Shutdown()
        {
            var isRunning = ProcessManager.CheckProcessRunningStatus(tbPath.Text);
            if (isRunning)
            {
                btnLaunch.Visible = false;
                labStatus.Text = "Closing";
                labStatus.ForeColor = Color.Orange;
                ProcessManager.CloseProcess(tbPath.Text);
            }

            cbEnable.Checked = true;
        }
    }
}
