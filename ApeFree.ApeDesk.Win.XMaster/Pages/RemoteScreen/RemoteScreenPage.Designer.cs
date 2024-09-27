namespace ApeFree.ApeDesk.Win.XMaster.Pages
{
    partial class RemoteScreenPage
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
            this.glp = new ApeFree.ApeForms.Core.Controls.Container.GridLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glp
            // 
            this.glp.AutoScroll = true;
            this.glp.AutoScrollMinSize = new System.Drawing.Size(404, 231);
            this.glp.DisplayColumn = 2;
            this.glp.DisplayRow = 2;
            this.glp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glp.Location = new System.Drawing.Point(3, 17);
            this.glp.Name = "glp";
            this.glp.Size = new System.Drawing.Size(569, 353);
            this.glp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Screen";
            // 
            // RemoteScreenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RemoteScreenPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(595, 393);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ApeForms.Core.Controls.Container.GridLayoutPanel glp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
