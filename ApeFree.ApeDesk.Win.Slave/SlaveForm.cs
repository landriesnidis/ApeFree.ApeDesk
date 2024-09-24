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

namespace ApeFree.ApeDesk.Win.Slave
{
    public partial class SlaveForm : Form
    {
        private TerminalInfo hostInfo = new TerminalInfo();
        public RpcTerminal Terminal { get; private set; }

        private MqttRpcTerminalAddon addon;

        public SlaveForm()
        {
            InitializeComponent();
        }

        private void Print(string msg)
        {
            tbLog.Invoke(new Action(() =>
            {
                tbLog.AppendText($"{DateTime.Now} {msg}");
            }));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            hostInfo.Name = new Random().Next(1000,9999).ToString();
            Terminal = new RpcTerminal(hostInfo);

            addon = new MqttRpcTerminalAddon(Terminal, tbIP.Text, (int)nudPort.Value);
            Terminal.Addons.Add(addon);

            var wcd = new WinControlledDevice(tbServiceName.Text);
            Terminal.RegisterService(wcd);

            gbNetwork.Enabled = false;
            propertyGrid.SelectedObject = wcd;
        }
    }
}
