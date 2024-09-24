namespace ApeFree.ApeDesk.Win.Master
{
    partial class SubForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbNetwork = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labMouseLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.picScreen = new ApeFree.ApeDesk.Win.Master.RemoteScreenView();
            this.folderBrowserView = new ApeFree.ApeDesk.Win.Master.DriveBrowserView();
            this.processManagerView = new ApeFree.ApeDesk.Win.Master.Views.ProcessManagerView();
            this.gbNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNetwork
            // 
            this.gbNetwork.Controls.Add(this.label2);
            this.gbNetwork.Controls.Add(this.tbServiceName);
            this.gbNetwork.Controls.Add(this.label3);
            this.gbNetwork.Controls.Add(this.btnConnect);
            this.gbNetwork.Controls.Add(this.tbIP);
            this.gbNetwork.Controls.Add(this.nudPort);
            this.gbNetwork.Controls.Add(this.label1);
            this.gbNetwork.Location = new System.Drawing.Point(12, 12);
            this.gbNetwork.Name = "gbNetwork";
            this.gbNetwork.Size = new System.Drawing.Size(321, 112);
            this.gbNetwork.TabIndex = 17;
            this.gbNetwork.TabStop = false;
            this.gbNetwork.Text = "Network";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Service Name";
            // 
            // tbServiceName
            // 
            this.tbServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceName.Location = new System.Drawing.Point(97, 70);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(131, 21);
            this.tbServiceName.TabIndex = 17;
            this.tbServiceName.Text = "wcd";
            this.tbServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Broker IP";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(234, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 75);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbIP
            // 
            this.tbIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIP.Location = new System.Drawing.Point(97, 16);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(131, 21);
            this.tbIP.TabIndex = 15;
            this.tbIP.Text = "10.255.0.197";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPort
            // 
            this.nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPort.Location = new System.Drawing.Point(97, 43);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(131, 21);
            this.nudPort.TabIndex = 8;
            this.nudPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPort.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 130);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(720, 455);
            this.tabControl.TabIndex = 20;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picScreen);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Screen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMouseLocation});
            this.statusStrip1.Location = new System.Drawing.Point(3, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labMouseLocation
            // 
            this.labMouseLocation.Name = "labMouseLocation";
            this.labMouseLocation.Size = new System.Drawing.Size(44, 17);
            this.labMouseLocation.Text = "Ready";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.folderBrowserView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.processManagerView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(712, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Process";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // picScreen
            // 
            this.picScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScreen.Location = new System.Drawing.Point(3, 3);
            this.picScreen.Margin = new System.Windows.Forms.Padding(2);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(706, 401);
            this.picScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScreen.TabIndex = 0;
            this.picScreen.TabStop = false;
            this.picScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picScreen_MouseMove);
            // 
            // folderBrowserView
            // 
            this.folderBrowserView.BackColor = System.Drawing.Color.White;
            this.folderBrowserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderBrowserView.Location = new System.Drawing.Point(3, 3);
            this.folderBrowserView.Name = "folderBrowserView";
            this.folderBrowserView.Size = new System.Drawing.Size(706, 423);
            this.folderBrowserView.TabIndex = 0;
            // 
            // processManagerView
            // 
            this.processManagerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processManagerView.Location = new System.Drawing.Point(3, 3);
            this.processManagerView.Name = "processManagerView";
            this.processManagerView.Size = new System.Drawing.Size(706, 423);
            this.processManagerView.TabIndex = 0;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 596);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gbNetwork);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制端";
            this.gbNetwork.ResumeLayout(false);
            this.gbNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RemoteScreenView picScreen;
        private System.Windows.Forms.GroupBox gbNetwork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DriveBrowserView folderBrowserView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labMouseLocation;
        private System.Windows.Forms.TabPage tabPage3;
        private Views.ProcessManagerView processManagerView;
    }
}

