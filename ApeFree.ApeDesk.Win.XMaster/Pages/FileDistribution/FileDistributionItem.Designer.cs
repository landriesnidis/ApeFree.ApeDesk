namespace ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution
{
    partial class FileDistributionItem
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
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFolderPath = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labServiceName = new System.Windows.Forms.Label();
            this.btnBrowser = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Checked = true;
            this.cbEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnable.Location = new System.Drawing.Point(9, 40);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(15, 14);
            this.cbEnable.TabIndex = 0;
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnBrowser);
            this.panel1.Controls.Add(this.tbFolderPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(530, 47);
            this.panel1.TabIndex = 1;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFolderPath.Location = new System.Drawing.Point(7, 20);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(490, 19);
            this.tbFolderPath.TabIndex = 1;
            this.tbFolderPath.Text = "";
            this.tbFolderPath.TextChanged += new System.EventHandler(this.tbFolderPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Path:";
            // 
            // labServiceName
            // 
            this.labServiceName.AutoSize = true;
            this.labServiceName.Location = new System.Drawing.Point(28, 5);
            this.labServiceName.Name = "labServiceName";
            this.labServiceName.Size = new System.Drawing.Size(77, 12);
            this.labServiceName.TabIndex = 2;
            this.labServiceName.Text = "Service Name";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnBrowser.Location = new System.Drawing.Point(504, 20);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(18, 19);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "…";
            this.btnBrowser.UsePureColorIcon = true;
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // FileDistributionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labServiceName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbEnable);
            this.Name = "FileDistributionItem";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 10, 10);
            this.Size = new System.Drawing.Size(570, 77);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEnable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbFolderPath;
        private System.Windows.Forms.Label labServiceName;
        private ApeForms.Core.Controls.SimpleButton btnBrowser;
    }
}
