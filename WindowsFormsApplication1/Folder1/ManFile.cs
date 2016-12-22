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
        SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
        public ManFile()
        {
            InitializeComponent();
        }
        private void ManFile_Load(object sender, EventArgs e) //界面初始化
        {
            // TODO: 这行代码将数据加载到表“rSGLDataSet.employee”中。您可以根据需要移动或删除它。
            //this.employeeTableAdapter.Fill(this.rSGLDataSet.employee);
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

            S_6.Items.AddRange(new object[] {
                "文盲",
                "幼儿园",
                "小学",
                "初中",
                "高中",
                "大专",
                "本科",
                "研究生",
                "博士",
                "硕士",

              });
            S_2.Items.AddRange(new object[] {
                "汉",
                "其他",
              });

            S_7.Items.AddRange(new object[] {
                "群众",
                "党员",

              });
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
            switch (comboBox1.Text)
            {
                case "按工号查询": tj = "e_number"; break;
                case "按姓名查询": tj = "e_name"; break;
                case "按性别查询": tj = "e_gender"; break;
                case "按民族查询": tj = "e_nation"; break;
                case "按文化程度查询": tj = "e_education"; break;
                case "按政治面貌查询": tj = "e_political"; break;

            }
            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");
            string xyz = (string)dataGridView1.CurrentRow.Cells[0].Value;
            string cmd = "select * from employee where e_number = '" + xyz + "'";
            //MessageBox.Show(xyz);
            SqlCommand lo_cmd = new SqlCommand(cmd, lo_conn);

            using (lo_conn)
            {
                lo_conn.Open();

                SqlDataReader lo_reader = lo_cmd.ExecuteReader();

                if (lo_reader.HasRows)
                {
                    while (lo_reader.Read())
                    {
                        S_0.Text += lo_reader["e_number"];
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
                        textBox2.Text = "查询成功";
                    }

                }
                else { textBox2.Text = "未查询到数据"; }
            }
        }
        private void Sut_Add_Click_1(object sender, EventArgs e) //新增按钮
        {
            string bh, xm, mz, sr, nl, xb, wh, zz, sf, ad, sz, sj;
            bh = "'" + S_0.Text + "'";
            xm = "'" + S_1.Text + "'";
            mz = "'" + S_2.Text + "'";
            DateTime a = Convert.ToDateTime(S_3.Text);
            S_3.Text = a.Year + "-" + a.Month + "-" + a.Day;
            sr = "'" + S_3.Text + "'";
            nl = S_4.Text;
            xb = "'" + S_5.Text + "'";
            wh = "'" + S_6.Text + "'";
            zz = "'" + S_7.Text + "'";
            sf = "'" + S_8.Text + "'";
            ad = "'" + S_9.Text + "'";
            sz = S_10.Text;
            sj = "'" + S_11.Text + "'";
            string strcon = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strcon;
            SqlCommand cmd = new SqlCommand("insert into employee(e_number,e_name,e_nation,e_birthday,e_age,e_gender,e_education,e_political,e_IDnumber,e_homeaddress,e_salary,e_telephonenumber) values(" + bh + "," + xm + "," + mz + "," + sr + "," + nl + "," + xb + "," + wh + "," + zz + "," + sf + "," + ad + "," + sz + "," + sj + ")", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void N_Next_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e) //查询按钮
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
            switch (comboBox1.Text)
            {
                case "按工号查询": tj = "e_number"; break;
                case "按姓名查询": tj = "e_name"; break;
                case "按性别查询": tj = "e_gender"; break;
                case "按民族查询": tj = "e_nation"; break;
                case "按文化程度查询": tj = "e_education"; break;
                case "按政治面貌查询": tj = "e_political"; break;

            }



            //lo_conn.Open();
            //SqlCommand lo_cmd = new SqlCommand("select * from employee where "+ tj + "= "+ "'" + comboBox2.Text + "'", lo_conn);
            //SqlDataReader lo_reader = lo_cmd.ExecuteReader();
            /*
            if (lo_reader.HasRows)
            {
                while (lo_reader.Read())
                {
                    S_0.Text += lo_reader["e_number"];
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
                    textBox2.Text = "查询成功";
                }

            }
            else { textBox2.Text = "未查询到数据"; }
            */
            using (lo_conn)
            {
                lo_conn.ConnectionString = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
                lo_conn.Open();
                string x;
                x = "select * from employee where " + tj + " LIKE " + "'%" + comboBox2.Text +  "%'";
                //MessageBox.Show(x);
                SqlCommand lo_cmd = new SqlCommand(x, lo_conn);
                SqlDataAdapter da = new SqlDataAdapter(lo_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "e_number");
                //da.Fill(ds, "e_name");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "e_number";
                dataGridView1.Columns[0].DataPropertyName = ds.Tables[0].Columns[0].ToString();
                da.Fill(ds, "e_name");
                //da.Fill(ds, "e_name");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "e_name";
                dataGridView1.Columns[1].DataPropertyName = ds.Tables[1].Columns[1].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Sut_Amend_Click_1(object sender, EventArgs e) //修改按钮
        {
            string bh, xm, mz, sr, nl, xb, wh, zz, sf, ad, sz, sj;
            bh = "e_number='" + S_0.Text + "'";
            xm = "e_name='" + S_1.Text + "'";
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
            SqlCommand cmd = new SqlCommand("update employee set " + bh + "," + xm + "," + mz + "," + sr + "," + nl + "," + xb + "," + wh + "," + zz + "," + sf + "," + ad + "," + sz + "," + sj + " where " + bh, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox2.Text = "修改成功";
        }
        private void S_8_TextChanged(object sender, EventArgs e)
        {

        }
        private void Sut_Delete_Click_1(object sender, EventArgs e) //删除成功
        {
            string bh;
            bh = "'" + S_0.Text + "'";

            string strcon = "Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strcon;
            SqlCommand cmd = new SqlCommand("delete from employee where e_number =" + bh, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox2.Text = "删除成功";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //二级查询菜单
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "按工号查询")
            {

                comboBox2.Items.AddRange(new object[] {
                "请输入工号",
              });
            }
            else if (comboBox1.Text == "按姓名查询")
            {
                comboBox2.Items.AddRange(new object[] {
                "请输入姓名",
              });
            }
            else if (comboBox1.Text == "按性别查询")
            {
                comboBox2.Items.AddRange(new object[] {
                "男",
                "女",
              });
            }
            else if (comboBox1.Text == "按民族查询")
            {
                comboBox2.Items.AddRange(new object[] {
                "汉",
                "其他",
              });
            }
            else if (comboBox1.Text == "按文化程度查询")
            {
                comboBox2.Items.AddRange(new object[] {
                "文盲",
                "幼儿园",
                "小学",
                "初中",
                "高中",
                "大专",
                "本科",
                "研究生",
                "博士",
                "硕士",

              });
            }
            else if (comboBox1.Text == "按政治面貌查询")
            {
                comboBox2.Items.AddRange(new object[] {
                "群众",
                "党员",

              });
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(Convert.ToString( dataGridView1.FirstDisplayedCell.Value));

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
            switch (comboBox1.Text)
            {
                case "按工号查询": tj = "e_number"; break;
                case "按姓名查询": tj = "e_name"; break;
                case "按性别查询": tj = "e_gender"; break;
                case "按民族查询": tj = "e_nation"; break;
                case "按文化程度查询": tj = "e_education"; break;
                case "按政治面貌查询": tj = "e_political"; break;

            }
            string cmd = string.Empty;
            SqlConnection lo_conn = new SqlConnection("Server=DESKTOP-RGQI6KB;Database=RSGL;uid=sa;pwd=123456");



            string xyz = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            cmd = "select * from employee where e_number = '" + xyz + "'";






            //MessageBox.Show(xyz);
            SqlCommand lo_cmd = new SqlCommand(cmd, lo_conn);

            using (lo_conn)
            {
                lo_conn.Open();

                SqlDataReader lo_reader = lo_cmd.ExecuteReader();

                if (lo_reader.HasRows)
                {
                    while (lo_reader.Read())
                    {
                        S_0.Text += lo_reader["e_number"];
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
                        textBox2.Text = "查询成功";
                    }

                }
                else { textBox2.Text = "未查询到数据"; }
            }
            /* #region a
    private void dataGridView1_SelectionChanged(object sender, EventArgs e)

    {

        //if (Convert.ToInt32((string)dataGridView1.FirstDisplayedCell.Value) <= Convert.ToInt32((string)dataGridView1.CurrentRow.Cells[0].Value))
        //{

        }
    }
    #endregion*/
        }
        // }
    }
}