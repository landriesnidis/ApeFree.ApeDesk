using ApeFree.ApeDesk.Core;
using ApeFree.ApeRpc;
using ApeFree.ApeRpc.Mqtt;
using STTech.CodePlus.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.Master
{
    public partial class MasterForm : Form
    {
        private TerminalInfo hostInfo = new TerminalInfo();
        public RpcTerminal Terminal { get; private set; }

        private MqttRpcTerminalAddon addon;

        private IControlledDevice RemoteDevice { get; set; }


        public MasterForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (RemoteDevice != null)
            {
                RemoteScreenCaptrueRefresh();
                return;
            }

            hostInfo.Name = new Random().Next(10000, 99999).ToString();
            Terminal = new RpcTerminal(hostInfo);

            addon = new MqttRpcTerminalAddon(Terminal, tbIP.Text, (int)nudPort.Value);
            Terminal.Addons.Add(addon);

            // 创建远程设备的RPC代理对象
            RemoteDevice = Terminal.GetService<IControlledDevice>(tbServiceName.Text);

            // 绑定屏幕控制器
            picScreen.Bind(RemoteDevice);
            RemoteScreenCaptrueRefresh();

            // 绑定文件夹浏览器
            folderBrowserView.Bind(RemoteDevice);

            // 绑定进程管理器
            processManagerView.Bind(RemoteDevice);
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string fileName;
            byte[] data;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    data = File.ReadAllBytes(filePath);
                    fileName = Path.GetFileName(filePath);
                }
                else
                {
                    return;
                }
            }

            RemoteDevice.SaveFile($@"C:\{fileName}", data);
        }

        private void RemoteScreenCaptrueRefresh()
        {
            if (tabControl.SelectedIndex != 0)
            {
                return;
            }

            if (RemoteDevice != null)
            {
                Task.Run(RemoteDevice.ScreenKeepAlive);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                var page = tabControl.TabPages[i];
                page.GetChildControls().ForEach(x => x.Visible = i == tabControl.SelectedIndex);
            }
            RemoteScreenCaptrueRefresh();
        }

        private void picScreen_MouseMove(object sender, MouseEventArgs e)
        {
            labMouseLocation.Text = picScreen.MouseLocation.ToString();
        }
    }
}
