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
    public partial class ManFile : Form
    {
        public ManFile()
        {
            InitializeComponent();
        }

        private void sqlconn() //链接到数据库
        {


        }


        private void ManFile_Load(object sender, EventArgs e)
        {
            /* SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
             lo_conn.Open();
             SqlCommand lo_cmd = new SqlCommand("select * from employee where e_age =19", lo_conn);
             SqlDataReader lo_reader = lo_cmd.ExecuteReader();
             textBox1.Text = "1";
             if (lo_reader.HasRows)
             {
                 while (lo_reader.Read())
                 {
                     textBox2.Text += lo_reader["e_number"];
                 }
             }*/


        }

        private void Sut_Add_Click(object sender, EventArgs e)
        {

        }

        private void Sut_Amend_Click(object sender, EventArgs e)
        {

        }

        private void Sut_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Sut_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Img_Save_Click(object sender, EventArgs e)
        {

        }

        private void S_14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sut_Add_Click_1(object sender, EventArgs e)
        {

        }

        private void N_Next_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tj=string.Empty;
            switch (comboBox1.Text)
            {
                case "按工号查询":tj = "e_number"; break;
                case "按姓名查询": tj = "e_name";break;
                case "按性别查询": tj = "e_gender"; break;
                case "按民族查询": tj = "e_nation"; break;
                case "按文化程度查询": tj = "e_education"; break;
                case "按政治面貌查询": tj = "e_political"; break;

            }


            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
            lo_conn.Open();
            SqlCommand lo_cmd = new SqlCommand("select * from employee where "+ tj + "= "+ "'" + comboBox2.Text + "'", lo_conn);
            SqlDataReader lo_reader = lo_cmd.ExecuteReader();
            textBox1.Text = "1";
            if (lo_reader.HasRows)
            {
                while (lo_reader.Read())
                {
                    S_0.Text += lo_reader["e_number"];
                    S_1.Text += lo_reader["e_name"];
                    S_2.Text += lo_reader["e_nation"];
                    S_3.Text += lo_reader["e_birthday"];
                    S_4.Text += lo_reader["e_age"];
                    S_5.Text += lo_reader["e_gender"];
                    S_6.Text += lo_reader["e_education"];
                    S_7.Text += lo_reader["e_political"];
                    S_8.Text += lo_reader["e_IDnumber"];
                    S_9.Text += lo_reader["e_homeaddress"];
                    S_10.Text += lo_reader["e_salary"];
                    S_11.Text += lo_reader["e_telephonenumber"];
                    textBox2.Text += lo_reader["e_number"];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sut_Amend_Click_1(object sender, EventArgs e)
        {
            string bh, xm, mz, sr, nl, xb, wh, zz, sf, ad, sz, sj;
            bh = "e_number='" + S_0.Text + "'";
            xm = "e_name='" + S_1.Text + "'";
            mz = "e_nation='" + S_2.Text + "'";
            DateTime a = Convert.ToDateTime(S_3.Text);
            S_3.Text = a.Year + "-" + a.Month + "-" + a.Day;
            sr = "e_birthday='" + S_3.Text +"'";
            
            nl = "e_age=" + S_4.Text;
            xb = "e_gender='" + S_5.Text + "'";
            wh = "e_education='" + S_6.Text + "'";
            zz = "e_political='" + S_7.Text + "'";
            sf = "e_IDnumber='" + S_8.Text + "'";
            ad = "e_homeaddress='" + S_9.Text + "'";
            sz = "e_salary=" + S_10.Text;
            sj = "e_telephonenumber='" + S_11.Text + "'";

            textBox2.Text = sr;

            string strcon ="Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strcon;  
            SqlCommand cmd = new SqlCommand("update employee set " +bh + "," + xm + ","+ mz + "," + sr + "," + nl + "," + xb + "," + wh + "," + zz + "," + sf + "," + ad + "," + sz + "," + sj+ " where e_number='0003'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
