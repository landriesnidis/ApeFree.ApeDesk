namespace ApeFree.ApeDesk.Win.XMaster
{
    partial class MainForm
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
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSettings = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.panelFill = new System.Windows.Forms.Panel();
            this.slideBox = new ApeFree.ApeForms.Core.Controls.SlideBox();
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.btnSettings);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(845, 40);
            this.panelTop.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSettings.BorderColor = System.Drawing.Color.Empty;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.Icon = global::ApeFree.ApeDesk.Win.XMaster.Properties.Resources.img_Settings;
            this.btnSettings.IconScaling = 0.6F;
            this.btnSettings.Location = new System.Drawing.Point(735, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(107, 34);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UsePureColorIcon = true;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.slideBox);
            this.panelFill.Controls.Add(this.panelBottom);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 40);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(845, 506);
            this.panelFill.TabIndex = 2;
            // 
            // slideBox
            // 
            this.slideBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideBox.Location = new System.Drawing.Point(0, 0);
            this.slideBox.Margin = new System.Windows.Forms.Padding(0);
            this.slideBox.Name = "slideBox";
            this.slideBox.Rate = 5;
            this.slideBox.ReviseValue = 5;
            this.slideBox.Size = new System.Drawing.Size(845, 456);
            this.slideBox.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoScroll = true;
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 456);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(845, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 548);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Text = "控制端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.Panel panelFill;
        private ApeForms.Core.Controls.SlideBox slideBox;
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private ApeForms.Core.Controls.SimpleButton btnSettings;
    }
}

