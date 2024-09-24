using ApeFree.ApeDesk.Core;
using System;
using System.Collections;
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
    public partial class ControlBoardForm : Form
    {
        private readonly IControlledDevice device;

        private ControlBoardForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public ControlBoardForm(IControlledDevice device) : this()
        {
            this.device = device;
        }

        private void ControlBoardForm_Load(object sender, EventArgs e)
        {
            device.ScreenUpdated += Device_ScreenUpdated;
            Task.Run(device.ScreenKeepAlive);
        }

        private void Device_ScreenUpdated(object? sender, ScreenUpdatedEventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(e.ImageData))
            {
                pictureBox1.Invoke(() =>
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = (Bitmap)Image.FromStream(ms);
                });
            }

            Task.Run(device.ScreenKeepAlive);
        }
    }
}
