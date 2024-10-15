namespace ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution
{
    partial class FileDistributionPage
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
            this.btnSelectAll = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnInverseSelection = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.tbLocalFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.glp = new ApeFree.ApeForms.Core.Controls.Container.GridLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.btnInverseSelection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.tbLocalFolder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSelectAll.BorderColor = System.Drawing.Color.Empty;
            this.btnSelectAll.BorderSize = 0;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectAll.Icon = null;
            this.btnSelectAll.IconScaling = 0.6F;
            this.btnSelectAll.Location = new System.Drawing.Point(8, 50);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(90, 35);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UsePureColorIcon = true;
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnInverseSelection
            // 
            this.btnInverseSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInverseSelection.BorderColor = System.Drawing.Color.Empty;
            this.btnInverseSelection.BorderSize = 0;
            this.btnInverseSelection.FlatAppearance.BorderSize = 0;
            this.btnInverseSelection.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnInverseSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnInverseSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnInverseSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverseSelection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInverseSelection.Icon = null;
            this.btnInverseSelection.IconScaling = 0.6F;
            this.btnInverseSelection.Location = new System.Drawing.Point(104, 50);
            this.btnInverseSelection.Name = "btnInverseSelection";
            this.btnInverseSelection.Size = new System.Drawing.Size(90, 35);
            this.btnInverseSelection.TabIndex = 9;
            this.btnInverseSelection.Text = "Inverse";
            this.btnInverseSelection.UsePureColorIcon = true;
            this.btnInverseSelection.UseVisualStyleBackColor = false;
            this.btnInverseSelection.Click += new System.EventHandler(this.btnInverseSelection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folder：";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSend.BorderColor = System.Drawing.Color.Empty;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Icon = null;
            this.btnSend.IconScaling = 0.6F;
            this.btnSend.Location = new System.Drawing.Point(548, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 21);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UsePureColorIcon = true;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbLocalFolder
            // 
            this.tbLocalFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocalFolder.Location = new System.Drawing.Point(65, 20);
            this.tbLocalFolder.Name = "tbLocalFolder";
            this.tbLocalFolder.Size = new System.Drawing.Size(477, 21);
            this.tbLocalFolder.TabIndex = 0;
            this.tbLocalFolder.TextChanged += new System.EventHandler(this.tbLocalFolder_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.glp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote Folder";
            // 
            // glp
            // 
            this.glp.AutoScroll = true;
            this.glp.DisplayColumn = 1;
            this.glp.DisplayRow = 4;
            this.glp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glp.Location = new System.Drawing.Point(3, 17);
            this.glp.Name = "glp";
            this.glp.Size = new System.Drawing.Size(625, 330);
            this.glp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "                                                                                 " +
    "                                                                ";
            // 
            // FileDistributionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileDistributionPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(651, 476);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private ApeForms.Core.Controls.Container.GridLayoutPanel glp;
        private System.Windows.Forms.TextBox tbLocalFolder;
        private ApeForms.Core.Controls.SimpleButton btnSend;
        private System.Windows.Forms.Label label2;
        private ApeForms.Core.Controls.SimpleButton btnSelectAll;
        private ApeForms.Core.Controls.SimpleButton btnInverseSelection;
    }
}
