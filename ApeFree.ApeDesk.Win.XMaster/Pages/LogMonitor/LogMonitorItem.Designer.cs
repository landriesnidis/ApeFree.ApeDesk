namespace ApeFree.ApeDesk.Win.XMaster.Pages.LogMonitor
{
    partial class LogMonitorItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLogContent = new System.Windows.Forms.RichTextBox();
            this.labSerivceName = new System.Windows.Forms.Label();
            this.labFileName = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.tbLogContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("黑体", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(642, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // tbLogContent
            // 
            this.tbLogContent.BackColor = System.Drawing.Color.White;
            this.tbLogContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogContent.Font = new System.Drawing.Font("宋体", 12F);
            this.tbLogContent.Location = new System.Drawing.Point(5, 20);
            this.tbLogContent.Name = "tbLogContent";
            this.tbLogContent.ReadOnly = true;
            this.tbLogContent.Size = new System.Drawing.Size(290, 253);
            this.tbLogContent.TabIndex = 0;
            this.tbLogContent.Text = "";
            // 
            // labSerivceName
            // 
            this.labSerivceName.BackColor = System.Drawing.Color.Gainsboro;
            this.labSerivceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSerivceName.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSerivceName.Location = new System.Drawing.Point(0, 0);
            this.labSerivceName.Name = "labSerivceName";
            this.labSerivceName.Size = new System.Drawing.Size(642, 20);
            this.labSerivceName.TabIndex = 1;
            this.labSerivceName.Text = "Service Name";
            this.labSerivceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labFileName
            // 
            this.labFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labFileName.Font = new System.Drawing.Font("黑体", 9F);
            this.labFileName.Location = new System.Drawing.Point(0, 20);
            this.labFileName.Name = "labFileName";
            this.labFileName.Size = new System.Drawing.Size(642, 20);
            this.labFileName.TabIndex = 2;
            this.labFileName.Text = "File Name";
            this.labFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstLog
            // 
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 12;
            this.lstLog.Location = new System.Drawing.Point(0, 40);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(642, 238);
            this.lstLog.TabIndex = 3;
            this.lstLog.SelectedValueChanged += new System.EventHandler(this.lstLog_SelectedValueChanged);
            // 
            // LogMonitorItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.labFileName);
            this.Controls.Add(this.labSerivceName);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogMonitorItem";
            this.Size = new System.Drawing.Size(942, 278);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbLogContent;
        private System.Windows.Forms.Label labSerivceName;
        private System.Windows.Forms.Label labFileName;
        private System.Windows.Forms.ListBox lstLog;
    }
}
