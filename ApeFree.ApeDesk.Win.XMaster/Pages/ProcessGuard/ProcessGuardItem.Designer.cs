namespace ApeFree.ApeDesk.Win.XMaster.Pages.ProcessGuard
{
    partial class ProcessGuardItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.btnLaunch = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnLaunch);
            this.groupBox.Controls.Add(this.btnBrowser);
            this.groupBox.Controls.Add(this.cbEnable);
            this.groupBox.Controls.Add(this.labStatus);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.tbPath);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(389, 80);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Process";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBrowser.BorderColor = System.Drawing.Color.Empty;
            this.btnBrowser.BorderSize = 0;
            this.btnBrowser.FlatAppearance.BorderSize = 0;
            this.btnBrowser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowser.Icon = null;
            this.btnBrowser.IconScaling = 0.6F;
            this.btnBrowser.Location = new System.Drawing.Point(361, 20);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(18, 19);
            this.btnBrowser.TabIndex = 5;
            this.btnBrowser.Text = "…";
            this.btnBrowser.UsePureColorIcon = true;
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // cbEnable
            // 
            this.cbEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(376, 0);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(15, 14);
            this.cbEnable.TabIndex = 4;
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStatus.ForeColor = System.Drawing.Color.DimGray;
            this.labStatus.Location = new System.Drawing.Point(71, 49);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(54, 12);
            this.labStatus.TabIndex = 3;
            this.labStatus.Text = "Unkonwn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "App State: ";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(73, 18);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(282, 21);
            this.tbPath.TabIndex = 1;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Path: ";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLaunch.BorderColor = System.Drawing.Color.Empty;
            this.btnLaunch.BorderSize = 0;
            this.btnLaunch.FlatAppearance.BorderSize = 0;
            this.btnLaunch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnLaunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLaunch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaunch.Icon = null;
            this.btnLaunch.IconScaling = 0.6F;
            this.btnLaunch.Location = new System.Drawing.Point(312, 46);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(67, 19);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "🚀Launch";
            this.btnLaunch.UsePureColorIcon = true;
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Visible = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // ProcessGuardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ProcessGuardItem";
            this.Size = new System.Drawing.Size(389, 80);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEnable;
        private System.Windows.Forms.Timer timerStatus;
        private ApeForms.Core.Controls.SimpleButton btnBrowser;
        private ApeForms.Core.Controls.SimpleButton btnLaunch;
    }
}
