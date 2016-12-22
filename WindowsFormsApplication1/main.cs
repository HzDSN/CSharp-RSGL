using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public string contsql = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
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
            login login_username = new login();
            SqlConnection mysql = new SqlConnection(contsql);
            mysql.Open();
            SqlCommand mycmd = new SqlCommand("SELECT * FROM position ", mysql);
            SqlDataReader sqldr = mycmd.ExecuteReader();
            while (sqldr.Read())
            {
                if (temp.e_num == sqldr["e_number"].ToString())
                {
                    string M_str_sql_position = sqldr["e_position"].ToString();
                    if (M_str_sql_position == "经理")
                    {
                        ManFile child = new ManFile();
                        child.TopLevel = false;
                        child.Dock = System.Windows.Forms.DockStyle.Fill;
                        child.FormBorderStyle = FormBorderStyle.None;
                        child.Parent = this.panel;
                        this.panel.Controls.Add(child);
                        child.Show();
                    }
                    else if (M_str_sql_position == "员工")
                    {
                        WindowsFormsApplication1.Folder1.userabc child = new WindowsFormsApplication1.Folder1.userabc();
                        child.TopLevel = false;
                        child.Dock = System.Windows.Forms.DockStyle.Fill;
                        child.FormBorderStyle = FormBorderStyle.None;
                        child.Parent = this.panel;
                        this.panel.Controls.Add(child);
                        child.Show();
                    }
                }
            }

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
