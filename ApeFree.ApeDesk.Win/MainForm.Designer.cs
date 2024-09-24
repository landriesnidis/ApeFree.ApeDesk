using ApeFree.ApeForms.Core.Controls;

namespace ApeFree.ApeDesk.Win
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
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            tbLocalCode = new RoundTextPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            btnConnect = new SimpleButton();
            tbRemoteCode = new RoundTextPanel();
            label6 = new Label();
            simpleButton2 = new SimpleButton();
            panel6 = new Panel();
            roundTextPanel1 = new RoundTextPanel();
            roundTextPanel3 = new RoundTextPanel();
            label4 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            roundTextPanel4 = new RoundTextPanel();
            simpleButton1 = new SimpleButton();
            roundTextPanel2 = new RoundTextPanel();
            label5 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 721);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 150);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 571);
            panel5.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 150);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tbLocalCode);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 13);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 180);
            panel3.TabIndex = 1;
            // 
            // tbLocalCode
            // 
            tbLocalCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLocalCode.BackColor = SystemColors.Window;
            tbLocalCode.BorderColor = SystemColors.Highlight;
            tbLocalCode.BorderWidth = (ushort)2;
            tbLocalCode.CornerRadius = 20;
            tbLocalCode.Font = new Font("微软雅黑", 10F);
            tbLocalCode.Hint = null;
            tbLocalCode.HintColor = Color.Gray;
            tbLocalCode.Location = new Point(30, 110);
            tbLocalCode.Margin = new Padding(3, 4, 3, 4);
            tbLocalCode.MinimumSize = new Size(30, 28);
            tbLocalCode.Name = "tbLocalCode";
            tbLocalCode.ReadOnly = true;
            tbLocalCode.Size = new Size(659, 50);
            tbLocalCode.TabIndex = 5;
            tbLocalCode.TabStop = false;
            tbLocalCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "设备代码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 2;
            label1.Text = "此设备";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(30, 30);
            label3.Name = "label3";
            label3.Size = new Size(183, 36);
            label3.TabIndex = 4;
            label3.Text = "远程控制设备";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(btnConnect);
            panel4.Controls.Add(tbRemoteCode);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 201);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(720, 180);
            panel4.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnect.BackColor = Color.FromArgb(0, 122, 204);
            btnConnect.BorderColor = Color.Empty;
            btnConnect.BorderSize = 0;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatAppearance.CheckedBackColor = Color.FromArgb(1, 135, 225);
            btnConnect.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 99, 164);
            btnConnect.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 147, 246);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold);
            btnConnect.ForeColor = Color.WhiteSmoke;
            btnConnect.Icon = null;
            btnConnect.IconScaling = 0.6F;
            btnConnect.Location = new Point(575, 110);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(114, 50);
            btnConnect.TabIndex = 14;
            btnConnect.TabStop = false;
            btnConnect.Text = "连接";
            btnConnect.UsePureColorIcon = true;
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbRemoteCode
            // 
            tbRemoteCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRemoteCode.BackColor = SystemColors.Window;
            tbRemoteCode.BorderColor = SystemColors.Highlight;
            tbRemoteCode.BorderWidth = (ushort)2;
            tbRemoteCode.CornerRadius = 20;
            tbRemoteCode.Font = new Font("微软雅黑", 10F);
            tbRemoteCode.Hint = null;
            tbRemoteCode.HintColor = Color.Gray;
            tbRemoteCode.Location = new Point(30, 110);
            tbRemoteCode.Margin = new Padding(3, 4, 3, 4);
            tbRemoteCode.MinimumSize = new Size(30, 28);
            tbRemoteCode.Name = "tbRemoteCode";
            tbRemoteCode.ReadOnly = false;
            tbRemoteCode.Size = new Size(539, 50);
            tbRemoteCode.TabIndex = 10;
            tbRemoteCode.TabStop = false;
            tbRemoteCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(30, 80);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "设备代码";
            // 
            // simpleButton2
            // 
            simpleButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            simpleButton2.BackColor = Color.FromArgb(0, 122, 204);
            simpleButton2.BorderColor = Color.Empty;
            simpleButton2.BorderSize = 0;
            simpleButton2.FlatAppearance.BorderSize = 0;
            simpleButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(1, 135, 225);
            simpleButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 99, 164);
            simpleButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 147, 246);
            simpleButton2.FlatStyle = FlatStyle.Flat;
            simpleButton2.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold);
            simpleButton2.ForeColor = Color.WhiteSmoke;
            simpleButton2.Icon = null;
            simpleButton2.IconScaling = 0.6F;
            simpleButton2.Location = new Point(575, 110);
            simpleButton2.Margin = new Padding(3, 4, 3, 4);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(114, 50);
            simpleButton2.TabIndex = 13;
            simpleButton2.TabStop = false;
            simpleButton2.Text = "确定";
            simpleButton2.UsePureColorIcon = true;
            simpleButton2.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(roundTextPanel1);
            panel6.Controls.Add(simpleButton2);
            panel6.Controls.Add(roundTextPanel3);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(12, 388);
            panel6.Name = "panel6";
            panel6.Size = new Size(720, 180);
            panel6.TabIndex = 3;
            // 
            // roundTextPanel1
            // 
            roundTextPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundTextPanel1.BackColor = SystemColors.Window;
            roundTextPanel1.BorderColor = SystemColors.Highlight;
            roundTextPanel1.BorderWidth = (ushort)2;
            roundTextPanel1.CornerRadius = 20;
            roundTextPanel1.Font = new Font("微软雅黑", 10F);
            roundTextPanel1.Hint = null;
            roundTextPanel1.HintColor = Color.Gray;
            roundTextPanel1.Location = new Point(469, 110);
            roundTextPanel1.Margin = new Padding(3, 4, 3, 4);
            roundTextPanel1.MinimumSize = new Size(30, 28);
            roundTextPanel1.Name = "roundTextPanel1";
            roundTextPanel1.ReadOnly = true;
            roundTextPanel1.Size = new Size(100, 50);
            roundTextPanel1.TabIndex = 14;
            roundTextPanel1.TabStop = false;
            roundTextPanel1.Text = "40902";
            roundTextPanel1.TextAlign = HorizontalAlignment.Center;
            // 
            // roundTextPanel3
            // 
            roundTextPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundTextPanel3.BackColor = SystemColors.Window;
            roundTextPanel3.BorderColor = SystemColors.Highlight;
            roundTextPanel3.BorderWidth = (ushort)2;
            roundTextPanel3.CornerRadius = 20;
            roundTextPanel3.Font = new Font("微软雅黑", 10F);
            roundTextPanel3.Hint = null;
            roundTextPanel3.HintColor = Color.Gray;
            roundTextPanel3.Location = new Point(30, 110);
            roundTextPanel3.Margin = new Padding(3, 4, 3, 4);
            roundTextPanel3.MinimumSize = new Size(30, 28);
            roundTextPanel3.Name = "roundTextPanel3";
            roundTextPanel3.ReadOnly = true;
            roundTextPanel3.Size = new Size(433, 50);
            roundTextPanel3.TabIndex = 8;
            roundTextPanel3.TabStop = false;
            roundTextPanel3.Text = "127.0.0.1";
            roundTextPanel3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(30, 80);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "网络地址 / 端口";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(30, 30);
            label7.Name = "label7";
            label7.Size = new Size(99, 36);
            label7.TabIndex = 6;
            label7.Text = "服务器";
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel3);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(250, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(756, 721);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(roundTextPanel4);
            panel8.Controls.Add(simpleButton1);
            panel8.Controls.Add(roundTextPanel2);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(12, 575);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(720, 180);
            panel8.TabIndex = 4;
            // 
            // roundTextPanel4
            // 
            roundTextPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundTextPanel4.BackColor = SystemColors.Window;
            roundTextPanel4.BorderColor = SystemColors.Highlight;
            roundTextPanel4.BorderWidth = (ushort)2;
            roundTextPanel4.CornerRadius = 20;
            roundTextPanel4.Font = new Font("微软雅黑", 10F);
            roundTextPanel4.Hint = null;
            roundTextPanel4.HintColor = Color.Gray;
            roundTextPanel4.Location = new Point(469, 110);
            roundTextPanel4.Margin = new Padding(3, 4, 3, 4);
            roundTextPanel4.MinimumSize = new Size(30, 28);
            roundTextPanel4.Name = "roundTextPanel4";
            roundTextPanel4.ReadOnly = true;
            roundTextPanel4.Size = new Size(100, 50);
            roundTextPanel4.TabIndex = 15;
            roundTextPanel4.TabStop = false;
            roundTextPanel4.Text = "40902";
            roundTextPanel4.TextAlign = HorizontalAlignment.Center;
            // 
            // simpleButton1
            // 
            simpleButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            simpleButton1.BackColor = Color.FromArgb(0, 122, 204);
            simpleButton1.BorderColor = Color.Empty;
            simpleButton1.BorderSize = 0;
            simpleButton1.FlatAppearance.BorderSize = 0;
            simpleButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(1, 135, 225);
            simpleButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 99, 164);
            simpleButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 147, 246);
            simpleButton1.FlatStyle = FlatStyle.Flat;
            simpleButton1.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold);
            simpleButton1.ForeColor = Color.WhiteSmoke;
            simpleButton1.Icon = null;
            simpleButton1.IconScaling = 0.6F;
            simpleButton1.Location = new Point(575, 110);
            simpleButton1.Margin = new Padding(3, 4, 3, 4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(114, 50);
            simpleButton1.TabIndex = 14;
            simpleButton1.TabStop = false;
            simpleButton1.Text = "创建";
            simpleButton1.UsePureColorIcon = true;
            simpleButton1.UseVisualStyleBackColor = false;
            // 
            // roundTextPanel2
            // 
            roundTextPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundTextPanel2.BackColor = SystemColors.Window;
            roundTextPanel2.BorderColor = SystemColors.Highlight;
            roundTextPanel2.BorderWidth = (ushort)2;
            roundTextPanel2.CornerRadius = 20;
            roundTextPanel2.Font = new Font("微软雅黑", 10F);
            roundTextPanel2.Hint = null;
            roundTextPanel2.HintColor = Color.Gray;
            roundTextPanel2.Location = new Point(30, 110);
            roundTextPanel2.Margin = new Padding(3, 4, 3, 4);
            roundTextPanel2.MinimumSize = new Size(30, 28);
            roundTextPanel2.Name = "roundTextPanel2";
            roundTextPanel2.ReadOnly = false;
            roundTextPanel2.Size = new Size(433, 50);
            roundTextPanel2.TabIndex = 10;
            roundTextPanel2.TabStop = false;
            roundTextPanel2.Text = "0.0.0.0";
            roundTextPanel2.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(30, 80);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 9;
            label5.Text = "网络地址 / 端口";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微软雅黑", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(30, 30);
            label8.Name = "label8";
            label8.Size = new Size(183, 36);
            label8.TabIndex = 4;
            label8.Text = "创建本地服务";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundTextPanel tbLocalCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private SimpleButton simpleButton2;
        private RoundTextPanel tbRemoteCode;
        private Label label6;
        private Panel panel6;
        private RoundTextPanel roundTextPanel3;
        private Label label4;
        private Label label7;
        private Panel panel7;
        private SimpleButton btnConnect;
        private RoundTextPanel roundTextPanel1;
        private Panel panel8;
        private SimpleButton simpleButton1;
        private RoundTextPanel roundTextPanel2;
        private Label label5;
        private Label label8;
        private RoundTextPanel roundTextPanel4;
    }
}

