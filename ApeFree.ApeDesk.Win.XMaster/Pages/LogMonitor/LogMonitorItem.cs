using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.LogMonitor
{
    public partial class LogMonitorItem : UserControl
    {
        /// <summary>
        /// 缓存消息
        /// </summary>
        public BindingList<string> CacheLines { get; }

        /// <summary>
        /// 显示最大行数
        /// </summary>
        public int MaxLines { get; set; } = 200;

        public string ServiceName { get => labSerivceName.Text; set => labSerivceName.Text = value; }
        public string FileName { get => labFileName.Text; set => labFileName.Text = value; }

        public LogMonitorItem()
        {
            InitializeComponent();

            CacheLines = new BindingList<string>();
            lstLog.DataSource = CacheLines;
        }

        public void AddLog(string[] lines)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AddLog(lines)));
                return;
            }

            CacheLines.RaiseListChangedEvents = false;

            foreach (var item in lines)
            {
                CacheLines.Add(item);
            }

            while (CacheLines.Count > MaxLines)
            {
                CacheLines.RemoveAt(0);
            }

            CacheLines.RaiseListChangedEvents = true;
            CacheLines.ResetBindings();

            // 列表滚动到最底部
            int visibleItems = lstLog.ClientSize.Height / lstLog.ItemHeight;
            lstLog.TopIndex = Math.Max(lstLog.Items.Count - visibleItems + 1, 0);
        }

        private void lstLog_SelectedValueChanged(object sender, EventArgs e)
        {
            tbLogContent.Text = lstLog.SelectedValue.ToString();
        }
    }
}
