using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
          

        }
        private void main_Load(object sender, EventArgs e)
        {

        }

        private void Tool_Stufind_Click(object sender, EventArgs e)
        {

        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要登出吗？", "登出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
                login show = new login();
                show.Show();
                this.Close();


            }
        }
        private void 关闭系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
                Application.Exit();
            }

        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Tool_Stuffbusic_Click(object sender, EventArgs e)
        {
            ManFile child = new ManFile();
            child.TopLevel = false;
            child.Dock = System.Windows.Forms.DockStyle.Fill;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Parent = this.panel;
            this.panel.Controls.Add(child);
            child.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 我得ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Folder1.userabc f2 = new WindowsFormsApplication1.Folder1.userabc();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
