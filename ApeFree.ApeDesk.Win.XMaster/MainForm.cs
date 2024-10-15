using ApeFree.ApeDesk.Core;
using ApeFree.ApeDesk.Win.XMaster.Pages;
using ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution;
using ApeFree.ApeDesk.Win.XMaster.Pages.ProcessGuard;
using ApeFree.ApeForms.Core.Controls;
using ApeFree.ApeForms.Forms.Notifications;
using ApeFree.ApeRpc;
using ApeFree.ApeRpc.Mqtt;
using ApeFree.DataStore;
using ApeFree.DataStore.Local;
using STTech.CodePlus.Threading;
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
        private LocalStore<GlobalSettings> settingsStore;

        private IControlledDevice[] RemoteDevice { get; set; }



        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            settingsStore = StoreFactory.Factory.CreateLocalStore<GlobalSettings>(new LocalStoreAccessSettings("./config.json"));
            settingsStore.Load();
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
            var names = new string[] { "wcd", "S160", "CA1" };
            var devices = names.Select(x => Terminal.GetService<IControlledDevice>(x)).ToArray();

            RemoteDevice = devices.AsParallel().Where(device =>
            {
                try
                {
                    var task = TaskExtension.Run(() => { _ = device.TerminalInfo; }, 1000);
                    task.Wait();
                    if (task.IsCompleted)
                    {
                        return true;
                    }
                }
                catch (Exception) { }
                return false;
            }).ToArray();

            var errorDevice = devices.Except(RemoteDevice);
            if (errorDevice.Any())
            {
                Toast.Show($"无法连接到远程服务 '{errorDevice.Select(x => x.ServiceName).Join(",")}'");
            }
        }

        public void AddPage(IPage page)
        {
            var ctrl = page as Control;
            var pageId = slideBox.AddPage(ctrl);

            SimpleButton btn = new SimpleButton();
            btn.Icon = page.PageIcon;
            btn.Text = page.PageTitle;
            btn.Height = panelBottom.Height-10;
            btn.Width = 150;
            btn.Parent = panelBottom;
            btn.Click += (s, e) => slideBox.Jump(pageId);
            btn.BackColor = btn.BackColor.Luminance(1 - 0.05f * panelBottom.Controls.Count);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Connect();
            AddPage(new RemoteScreenPage(RemoteDevice, settingsStore.Value));
            AddPage(new ProcessGuardPage(RemoteDevice, settingsStore.Value));
            AddPage(new FileDistributionPage(RemoteDevice, settingsStore.Value));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsStore.Save();
        }
    }
}
