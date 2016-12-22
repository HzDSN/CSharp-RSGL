namespace WindowsFormsApplication1
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Stuffbusic = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Stusum = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.我得ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_4,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu_4
            // 
            this.Menu_4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Stuffbusic,
            this.Tool_Stusum,
            this.我得ToolStripMenuItem});
            this.Menu_4.Name = "Menu_4";
            this.Menu_4.Size = new System.Drawing.Size(68, 21);
            this.Menu_4.Text = "人事管理";
            // 
            // Tool_Stuffbusic
            // 
            this.Tool_Stuffbusic.Name = "Tool_Stuffbusic";
            this.Tool_Stuffbusic.Size = new System.Drawing.Size(152, 22);
            this.Tool_Stuffbusic.Text = "人事档案管理";
            this.Tool_Stuffbusic.Click += new System.EventHandler(this.Tool_Stuffbusic_Click);
            // 
            // Tool_Stusum
            // 
            this.Tool_Stusum.Name = "Tool_Stusum";
            this.Tool_Stusum.Size = new System.Drawing.Size(152, 22);
            this.Tool_Stusum.Text = "人事资料统计";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登出ToolStripMenuItem,
            this.关闭系统ToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.登出ToolStripMenuItem.Text = "登出";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
            // 
            // 关闭系统ToolStripMenuItem
            // 
            this.关闭系统ToolStripMenuItem.Name = "关闭系统ToolStripMenuItem";
            this.关闭系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭系统ToolStripMenuItem.Text = "关闭系统";
            this.关闭系统ToolStripMenuItem.Click += new System.EventHandler(this.关闭系统ToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(659, 410);
            this.panel.TabIndex = 2;
            // 
            // 我得ToolStripMenuItem
            // 
            this.我得ToolStripMenuItem.Name = "我得ToolStripMenuItem";
            this.我得ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.我得ToolStripMenuItem.Text = "我得";
            this.我得ToolStripMenuItem.Click += new System.EventHandler(this.我得ToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 439);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_4;
        private System.Windows.Forms.ToolStripMenuItem Tool_Stuffbusic;
        private System.Windows.Forms.ToolStripMenuItem Tool_Stusum;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭系统ToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem 我得ToolStripMenuItem;
    }
}