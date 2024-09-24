using ApeFree.ApeDesk.Core;
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

namespace ApeFree.ApeDesk.Win
{
    public partial class MainForm : Form
    {
        private TerminalInfo hostInfo = new TerminalInfo();
        public RpcTerminal Terminal { get; }

        private MqttRpcTerminalAddon addon;

        public MainForm()
        {
            InitializeComponent();
            Text = $"{Application.ProductName} - {Application.ProductVersion}";

            // 随机本地Code
            tbLocalCode.Text = new Random().Next(10000, 99999).ToString();
            hostInfo.Name = tbLocalCode.Text;
            Terminal = new RpcTerminal(hostInfo);
            addon = new MqttRpcTerminalAddon(Terminal, "192.168.10.77", 1883);
            Terminal.Addons.Add(addon);

            Terminal.RegisterService(new WinControlledDevice(tbLocalCode.Text));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var device = Terminal.GetService<IControlledDevice>(tbRemoteCode.Text);

            using (var form = new ControlBoardForm(device))
            {
                form.ShowDialog();
            }
        }
    }
}
