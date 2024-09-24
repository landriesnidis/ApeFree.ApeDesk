using ApeFree.ApeDesk.Core;
using ApeFree.ApeRpc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApeFree.ApeDesk.Win.Master.Views
{
    public partial class ProcessManagerView : UserControl
    {
        private ProcessInfo[] _lastProcessInfos;

        public IProcessManager ProcessManager { get; private set; }

        public ProcessManagerView()
        {
            InitializeComponent();
        }

        public void Bind(IService service)
        {
            if (service is IProcessManager processManager)
            {
                ProcessManager = processManager;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var pis = ProcessManager.GetProcesses();
            _lastProcessInfos = pis;

            UpdateProcessListView();
        }

        private void UpdateProcessListView()
        {
            if (_lastProcessInfos == null || !_lastProcessInfos.Any())
            {
                return;
            }

            ProcessInfo[] pis;
            var keyword = tbSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                pis = _lastProcessInfos;
            }
            else
            {
                pis = _lastProcessInfos.Where(x =>
                    x.Id.ToString() == keyword ||
                    x.ProcessName.Contains(keyword) ||
                    (x.MainWindowTitle != null && x.MainWindowTitle.Contains(keyword)) ||
                    (x.FileName != null && x.FileName.Contains(keyword))
                ).ToArray();
            }

            var lvis = pis.Select(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ProcessName);

                lvi.SubItems.Add(item.Id.ToString());
                lvi.SubItems.Add(item.MainWindowTitle);
                lvi.SubItems.Add(FormatByteLength(item.WorkingSet64));
                lvi.SubItems.Add(item.UserName);
                lvi.SubItems.Add(item.FileName);
                lvi.Tag = item;
                return lvi;
            }).ToArray();

            listView.ModifyInUI(() =>
            {
                listView.Items.Clear();
                listView.Items.AddRange(lvis);
            });
        }

        public static string FormatByteLength(long byteLength)
        {
            const double kiloByte = 1024;
            const double megaByte = kiloByte * 1024;
            const double gigaByte = megaByte * 1024;

            if (byteLength < kiloByte)
            {
                return $"{byteLength} B";
            }
            else if (byteLength < megaByte)
            {
                return $"{byteLength / kiloByte:0.00} KB";
            }
            else if (byteLength < gigaByte)
            {
                return $"{byteLength / megaByte:0.00} MB";
            }
            else
            {
                return $"{byteLength / gigaByte:0.00} GB";
            }
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }

            var item = listView.SelectedItems[0];
            var pi = (ProcessInfo)item.Tag;

            ProcessManager.CloseProcessById(pi.Id);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateProcessListView();
        }
    }
}
