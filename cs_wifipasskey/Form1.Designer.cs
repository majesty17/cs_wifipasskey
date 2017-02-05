namespace wifi万能钥匙
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_scan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer_scan = new System.Windows.Forms.Timer(this.components);
            this.button_stop = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查询密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(12, 12);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(75, 23);
            this.button_scan.TabIndex = 0;
            this.button_scan.Text = "扫描";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 41);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(667, 366);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SSID无线名称";
            this.columnHeader1.Width = 212;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MAC地址";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RSSI";
            this.columnHeader4.Width = 53;
            // 
            // timer_scan
            // 
            this.timer_scan.Tick += new System.EventHandler(this.timer_scan_Tick);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(93, 12);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询密码ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 查询密码ToolStripMenuItem
            // 
            this.查询密码ToolStripMenuItem.Name = "查询密码ToolStripMenuItem";
            this.查询密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询密码ToolStripMenuItem.Text = "查询密码";
            this.查询密码ToolStripMenuItem.Click += new System.EventHandler(this.查询密码ToolStripMenuItem_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "密码";
            this.columnHeader3.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 407);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_scan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Timer timer_scan;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询密码ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

