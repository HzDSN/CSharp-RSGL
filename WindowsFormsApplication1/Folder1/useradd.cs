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
    public partial class useradd : Form
    {
        public useradd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
            lo_conn.Open();
            SqlCommand lo_cmd = new SqlCommand("select * from employee where e_number = '" + text_Name.Text + "'", lo_conn);
            SqlDataReader lo_reader = lo_cmd.ExecuteReader();

            if (lo_reader.HasRows)
            {
                while (lo_reader.Read())
                {             
                }

            }
            else {
               string strcon = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
               SqlConnection conn = new SqlConnection();
                conn.ConnectionString = strcon;
                SqlCommand cmd = new SqlCommand("insert into zhanghao (e_number, e_username, e_password) values('"+ text_Name.Text + "', 'hz"+ text_Name.Text + "', '"+ text_Pass.Text+ "')",conn );
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
        }

        private void useradd_Load(object sender, EventArgs e)
        {

        }

        private void text_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void useradd_Load_1(object sender, EventArgs e)
        {

        }
    }
}
