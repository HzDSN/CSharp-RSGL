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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)//关闭程序
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManFile f1 = new ManFile();
            f1.Show();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            bool M_bl_yn = false;
            if (textName.Text == string.Empty || textPass.Text == string.Empty)
            { MessageBox.Show("账号或密码不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else
            {
                #region 数据库连接
                string contsql = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
                SqlConnection mysql = new SqlConnection(contsql);
                mysql.Open();
                SqlCommand mycmd = new SqlCommand("SELECT * FROM zhanghao ", mysql);
                SqlDataReader sqldr = mycmd.ExecuteReader();
                #endregion
                #region 账号判断
                while (sqldr.Read())
                {
                    string M_str_sql_pwd = sqldr["e_password"].ToString();
                    string M_str_sql_user = sqldr["e_username"].ToString();
                    if (M_str_sql_user == textName.Text.Trim())
                    {
                        if (this.textName.Text.Trim() == M_str_sql_user && this.textPass.Text.Trim() == M_str_sql_pwd)
                        {
                            main login = new main();
                            login.Show();
                            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
                            this.Hide();
                            M_bl_yn = true;
                            break;                                                                           
                        }
                    }
                 }
                    if (M_bl_yn == false)
                    { MessageBox.Show("账号或密码错误,请重新输入！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                
                #endregion
              
            }
            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
            lo_conn.Open();
            SqlCommand lo_cmd = new SqlCommand("select * from zhanghao where e_username = " + "'" + textName.Text + "'", lo_conn);
            SqlDataReader lo_reader = lo_cmd.ExecuteReader();

            if (lo_reader.HasRows)
            {
                while (lo_reader.Read())
                {
                    temp.e_num = Convert.ToString(lo_reader["e_number"]);
                }

            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
