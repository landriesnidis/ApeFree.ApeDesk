namespace ApeFree.ApeDesk.Win.Master.Views
{
    partial class ProcessManagerView
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
            this.listView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMemorySize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKillProcess = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnRefresh = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new ApeFree.ApeForms.Core.Controls.RoundTextPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colId,
            this.colTitle,
            this.colMemorySize,
            this.colUser,
            this.colPath});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 35);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(597, 383);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 202;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 59;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            // 
            // colMemorySize
            // 
            this.colMemorySize.Text = "Memory";
            this.colMemorySize.Width = 64;
            // 
            // colUser
            // 
            this.colUser.Text = "User";
            this.colUser.Width = 101;
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 169;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btnKillProcess);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 40);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnKillProcess.BorderColor = System.Drawing.Color.Empty;
            this.btnKillProcess.BorderSize = 0;
            this.btnKillProcess.FlatAppearance.BorderSize = 0;
            this.btnKillProcess.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnKillProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnKillProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnKillProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillProcess.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKillProcess.Icon = null;
            this.btnKillProcess.IconScaling = 0.6F;
            this.btnKillProcess.Location = new System.Drawing.Point(514, 3);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(80, 35);
            this.btnKillProcess.TabIndex = 0;
            this.btnKillProcess.Text = "Kill Process";
            this.btnKillProcess.UsePureColorIcon = true;
            this.btnKillProcess.UseVisualStyleBackColor = false;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Empty;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(225)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(164)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(246)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Icon = null;
            this.btnRefresh.IconScaling = 0.6F;
            this.btnRefresh.Location = new System.Drawing.Point(428, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UsePureColorIcon = true;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(597, 35);
            this.panel1.TabIndex = 5;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tbSearch.BorderWidth = ((ushort)(2));
            this.tbSearch.CornerRadius = 20;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSearch.Hint = "Process Name \\ ID \\ Title \\ Path";
            this.tbSearch.HintColor = System.Drawing.Color.Gray;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.MinimumSize = new System.Drawing.Size(30, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(597, 32);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // ProcessManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProcessManagerView";
            this.Size = new System.Drawing.Size(597, 458);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colMemorySize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ApeForms.Core.Controls.SimpleButton btnKillProcess;
        private ApeForms.Core.Controls.SimpleButton btnRefresh;
        private System.Windows.Forms.ColumnHeader colUser;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.Panel panel1;
        private ApeForms.Core.Controls.RoundTextPanel tbSearch;
    }
}
