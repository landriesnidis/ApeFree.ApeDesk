namespace ApeFree.ApeDesk.Win.Slave
{
    partial class SlaveForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.gbNetwork = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.gbNetwork.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port";
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
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(3, 17);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(280, 367);
            this.tbLog.TabIndex = 7;
            this.tbLog.Text = "";
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
            this.gbNetwork.TabIndex = 16;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbLog);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 387);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSettings.Controls.Add(this.propertyGrid);
            this.gbSettings.Location = new System.Drawing.Point(12, 130);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(315, 269);
            this.gbSettings.TabIndex = 18;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(3, 17);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(309, 249);
            this.propertyGrid.TabIndex = 0;
            // 
            // PubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbNetwork);
            this.Name = "PubForm";
            this.Text = "受控端";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.gbNetwork.ResumeLayout(false);
            this.gbNetwork.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.GroupBox gbNetwork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServiceName;
    }
}

