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
            this.Tool_Stufind = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Stusum = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_8 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_NewLogon = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Setup = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_9 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_4,
            this.Menu_8,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_4
            // 
            this.Menu_4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Stuffbusic,
            this.Tool_Stufind,
            this.Tool_Stusum});
            this.Menu_4.Name = "Menu_4";
            this.Menu_4.Size = new System.Drawing.Size(68, 21);
            this.Menu_4.Text = "人事管理";
            this.Menu_4.Click += new System.EventHandler(this.Menu_4_Click);
            // 
            // Tool_Stuffbusic
            // 
            this.Tool_Stuffbusic.Name = "Tool_Stuffbusic";
            this.Tool_Stuffbusic.Size = new System.Drawing.Size(152, 22);
            this.Tool_Stuffbusic.Text = "人事档案管理";
            // 
            // Tool_Stufind
            // 
            this.Tool_Stufind.Name = "Tool_Stufind";
            this.Tool_Stufind.Size = new System.Drawing.Size(152, 22);
            this.Tool_Stufind.Text = "人事资料查询";
            // 
            // Tool_Stusum
            // 
            this.Tool_Stusum.Name = "Tool_Stusum";
            this.Tool_Stusum.Size = new System.Drawing.Size(152, 22);
            this.Tool_Stusum.Text = "人事资料统计";
            // 
            // Menu_8
            // 
            this.Menu_8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_NewLogon,
            this.Tool_Setup,
            this.Menu_9});
            this.Menu_8.Name = "Menu_8";
            this.Menu_8.Size = new System.Drawing.Size(68, 21);
            this.Menu_8.Text = "系统管理";
            // 
            // Tool_NewLogon
            // 
            this.Tool_NewLogon.Name = "Tool_NewLogon";
            this.Tool_NewLogon.Size = new System.Drawing.Size(124, 22);
            this.Tool_NewLogon.Text = "重新登录";
            // 
            // Tool_Setup
            // 
            this.Tool_Setup.Name = "Tool_Setup";
            this.Tool_Setup.Size = new System.Drawing.Size(124, 22);
            this.Tool_Setup.Text = "用户设置";
            // 
            // Menu_9
            // 
            this.Menu_9.Name = "Menu_9";
            this.Menu_9.Size = new System.Drawing.Size(124, 22);
            this.Menu_9.Text = "系统退出";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 439);
            this.Controls.Add(this.menuStrip1);
            this.Name = "main";
            this.Text = "main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_4;
        private System.Windows.Forms.ToolStripMenuItem Tool_Stuffbusic;
        private System.Windows.Forms.ToolStripMenuItem Tool_Stufind;
        private System.Windows.Forms.ToolStripMenuItem Tool_Stusum;
        private System.Windows.Forms.ToolStripMenuItem Menu_8;
        private System.Windows.Forms.ToolStripMenuItem Tool_NewLogon;
        private System.Windows.Forms.ToolStripMenuItem Tool_Setup;
        private System.Windows.Forms.ToolStripMenuItem Menu_9;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}