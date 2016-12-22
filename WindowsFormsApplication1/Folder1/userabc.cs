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

namespace WindowsFormsApplication1.Folder1
{
    public partial class userabc : Form
    {
        public userabc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repassword f1 = new repassword();
            f1.Show();
        }

        private void userabc_Load(object sender, EventArgs e)
        {

            S_0.Text = string.Empty;
            S_1.Text = string.Empty;
            S_2.Text = string.Empty;
            S_3.Text = string.Empty;
            S_4.Text = string.Empty;
            S_5.Text = string.Empty;
            S_6.Text = string.Empty;
            S_7.Text = string.Empty;
            S_8.Text = string.Empty;
            S_9.Text = string.Empty;
            S_10.Text = string.Empty;
            S_11.Text = string.Empty;

            string tj = string.Empty;
            tj = "e_number ";

            S_0.Text = temp.e_num;
            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
            lo_conn.Open();
            SqlCommand lo_cmd = new SqlCommand("select * from employee where " + tj + "= " + "'" + temp.e_num + "'", lo_conn);
            SqlDataReader lo_reader = lo_cmd.ExecuteReader();

            if (lo_reader.HasRows)
            {
                while (lo_reader.Read())
                {

                    S_1.Text += lo_reader["e_name"];
                    S_2.Text += lo_reader["e_nation"];
                    S_3.Text += lo_reader["e_birthday"];
                    DateTime a = Convert.ToDateTime(S_3.Text);
                    S_3.Text = a.Year + "-" + a.Month + "-" + a.Day;
                    S_4.Text += lo_reader["e_age"];
                    S_5.Text += lo_reader["e_gender"];
                    S_6.Text += lo_reader["e_education"];
                    S_7.Text += lo_reader["e_political"];
                    S_8.Text += lo_reader["e_IDnumber"];
                    S_9.Text += lo_reader["e_homeaddress"];
                    S_10.Text += lo_reader["e_salary"];
                    S_11.Text += lo_reader["e_telephonenumber"];

                }

            }
        }

        private void Sut_Amend_Click(object sender, EventArgs e)
        {
            string  mz, sr, nl, xb, wh, zz, sf, ad, sz, sj;
          
            mz = "e_nation='" + S_2.Text + "'";
            DateTime a = Convert.ToDateTime(S_3.Text);
            S_3.Text = a.Year + "-" + a.Month + "-" + a.Day;
            sr = "e_birthday='" + S_3.Text + "'";
            nl = "e_age=" + S_4.Text;
            xb = "e_gender='" + S_5.Text + "'";
            wh = "e_education='" + S_6.Text + "'";
            zz = "e_political='" + S_7.Text + "'";
            sf = "e_IDnumber='" + S_8.Text + "'";
            ad = "e_homeaddress='" + S_9.Text + "'";
            sz = "e_salary=" + S_10.Text;
            sj = "e_telephonenumber='" + S_11.Text + "'";



            string strcon = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strcon;
            SqlCommand cmd = new SqlCommand("update employee set " +  mz + "," + sr + "," + nl + "," + xb + "," + wh + "," + zz + "," + sf + "," + ad + "," + sz + "," + sj + " where e_number = " + temp.e_num, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
          
        }
    }
}
