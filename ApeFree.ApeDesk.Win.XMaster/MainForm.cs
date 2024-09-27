using ApeFree.ApeDesk.Core;
using ApeFree.ApeDesk.Win.XMaster.Pages;
using ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution;
using ApeFree.ApeDesk.Win.XMaster.Pages.ProcessGuard;
using ApeFree.ApeForms.Core.Controls;
using ApeFree.ApeRpc;
using ApeFree.ApeRpc.Mqtt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster
{
    public partial class MainForm : Form
    {
        private TerminalInfo hostInfo = new TerminalInfo();
        public RpcTerminal Terminal { get; private set; }
        private MqttRpcTerminalAddon addon;
        private IControlledDevice[] RemoteDevice { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Connect()
        {
            if (RemoteDevice != null)
            {
                return;
            }

            hostInfo.Name = new Random().Next(10000, 99999).ToString();
            Terminal = new RpcTerminal(hostInfo);

            addon = new MqttRpcTerminalAddon(Terminal, "10.255.0.197", 1883);
            Terminal.Addons.Add(addon);

            // 创建远程设备的RPC代理对象
            var names = new string[] { "wcd","S160" };
            RemoteDevice = names.Select(x => Terminal.GetService<IControlledDevice>(x)).ToArray();

            
        }

        public void AddPage(IPage page)
        {
            var ctrl = page as Control;
            var pageId = slideBox.AddPage(ctrl);

            SimpleButton btn = new SimpleButton();
            btn.Icon = page.PageIcon;
            btn.Text = page.PageTitle;
            btn.Width = 150;
            btn.Dock = DockStyle.Left;
            btn.Parent = panelBottom;
            btn.Click += (s, e) => slideBox.Jump(pageId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
            AddPage(new RemoteScreenPage(RemoteDevice));
            AddPage(new ProcessGuardPage(RemoteDevice));
            AddPage(new FileDistributionPage(RemoteDevice));
        }
    }
}
