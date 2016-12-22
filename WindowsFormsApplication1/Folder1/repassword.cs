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
    public partial class repassword : Form
    {
        public repassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ps = string.Empty;
            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
            lo_conn.Open();
            SqlCommand lo_cmd = new SqlCommand("select * from zhanghao where e_number = "+ "'" + temp.e_num + "'", lo_conn);
            SqlDataReader lo_reader = lo_cmd.ExecuteReader();

            if (lo_reader.HasRows)
            {
                while (lo_reader.Read())
                {
                     ps =Convert.ToString(lo_reader["e_password"]);
                }

            }
            if (ps == textBox2.Text)
            {
                if (textBox3.Text == textBox4.Text)
                { }
            }
            else
            {
            }



        }

        private void repassword_Load(object sender, EventArgs e)
        {
            textBox1.Text = "hz" + temp.e_num;
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox4.Text != string.Empty && textBox3.Text != string.Empty) { button1.Enabled = true; } else { button1.Enabled = false; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox4.Text != string.Empty && textBox3.Text != string.Empty) { button1.Enabled = true; } else { button1.Enabled = false; }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox4.Text != string.Empty && textBox3.Text != string.Empty) { button1.Enabled = true; } else { button1.Enabled = false; }

        }
    }
}
