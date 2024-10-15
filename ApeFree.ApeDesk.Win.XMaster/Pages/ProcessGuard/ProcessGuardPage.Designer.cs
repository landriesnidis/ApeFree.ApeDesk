namespace ApeFree.ApeDesk.Win.XMaster.Pages.ProcessGuard
{
    partial class ProcessGuardPage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLaunchAll = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnStopAll = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnSelectAll = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnInverseSelection = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glp
            // 
            this.glp.AutoScroll = true;
            this.glp.DisplayColumn = 1;
            this.glp.DisplayRow = 4;
            this.glp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glp.Location = new System.Drawing.Point(3, 17);
            this.glp.Name = "glp";
            this.glp.Size = new System.Drawing.Size(582, 400);
            this.glp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Process";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 61);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnLaunchAll);
            this.flowLayoutPanel1.Controls.Add(this.btnStopAll);
            this.flowLayoutPanel1.Controls.Add(this.btnSelectAll);
            this.flowLayoutPanel1.Controls.Add(this.btnInverseSelection);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLaunchAll
            // 
            this.btnLaunchAll.BackColor = System.Drawing.Color.Green;
            this.btnLaunchAll.BorderColor = System.Drawing.Color.Empty;
            this.btnLaunchAll.BorderSize = 0;
            this.btnLaunchAll.FlatAppearance.BorderSize = 0;
            this.btnLaunchAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.btnLaunchAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(1)))));
            this.btnLaunchAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(1)))));
            this.btnLaunchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaunchAll.Icon = null;
            this.btnLaunchAll.IconScaling = 0.6F;
            this.btnLaunchAll.Location = new System.Drawing.Point(3, 3);
            this.btnLaunchAll.Name = "btnLaunchAll";
            this.btnLaunchAll.Size = new System.Drawing.Size(90, 35);
            this.btnLaunchAll.TabIndex = 3;
            this.btnLaunchAll.Text = "Launch All";
            this.btnLaunchAll.UsePureColorIcon = true;
            this.btnLaunchAll.UseVisualStyleBackColor = false;
            this.btnLaunchAll.Click += new System.EventHandler(this.btnLaunchAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStopAll.BorderColor = System.Drawing.Color.Empty;
            this.btnStopAll.BorderSize = 0;
            this.btnStopAll.FlatAppearance.BorderSize = 0;
            this.btnStopAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnStopAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnStopAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnStopAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopAll.Icon = null;
            this.btnStopAll.IconScaling = 0.6F;
            this.btnStopAll.Location = new System.Drawing.Point(99, 3);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(90, 35);
            this.btnStopAll.TabIndex = 4;
            this.btnStopAll.Text = "Shutdown All";
            this.btnStopAll.UsePureColorIcon = true;
            this.btnStopAll.UseVisualStyleBackColor = false;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
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
            this.btnSelectAll.Location = new System.Drawing.Point(195, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(90, 35);
            this.btnSelectAll.TabIndex = 5;
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
            this.btnInverseSelection.Location = new System.Drawing.Point(291, 3);
            this.btnInverseSelection.Name = "btnInverseSelection";
            this.btnInverseSelection.Size = new System.Drawing.Size(90, 35);
            this.btnInverseSelection.TabIndex = 6;
            this.btnInverseSelection.Text = "Inverse";
            this.btnInverseSelection.UsePureColorIcon = true;
            this.btnInverseSelection.UseVisualStyleBackColor = false;
            this.btnInverseSelection.Click += new System.EventHandler(this.btnInverseSelection_Click);
            // 
            // ProcessGuardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProcessGuardPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(608, 501);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ApeForms.Core.Controls.Container.GridLayoutPanel glp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ApeForms.Core.Controls.SimpleButton btnLaunchAll;
        private ApeForms.Core.Controls.SimpleButton btnStopAll;
        private ApeForms.Core.Controls.SimpleButton btnSelectAll;
        private ApeForms.Core.Controls.SimpleButton btnInverseSelection;
    }
}
