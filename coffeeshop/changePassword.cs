using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class changePassword : Form
    {
        string sConn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vests\source\repos\coffeeshopApp\coffeeshop\order_list_DB.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();

        public changePassword()
        {
            InitializeComponent();
            //DB 연결 
            sqlConnect.ConnectionString = sConn;
            sqlConnect.Open();
            sqlCommand.Connection = sqlConnect;

            titleLb.Text = "현재 비밀번호 재확인";
            label1.Text = "현재 비밀번호";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Visible = false;
            textBox2.Visible = false;
            resetBtn.Visible = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //현재 비밀번호 확인 

            // ID PASSWORD 테이블에서 현재 비밀번호 불러오기 
            sqlCommand.CommandText = $"select password from admin_id_pw";
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            string _password = "";
            while (rdr.Read())
            {
                _password = rdr["password"].ToString();
            }
            rdr.Close();

            //비밀번호 재확인
            if (textBox1.Text == _password)
            {
                label2.Text = "재설정 비밀번호";
                label2.Visible = true;
                textBox2.Visible = true;
                confirmBtn.Visible = false;
                resetBtn.Visible = true;
                    
            }
                
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //비밀번호 재설정 입력 
            string newPassword = textBox2.Text;

            string passwordUpdate = $"update admin_id_pw set password={newPassword} where id=N'admin'";
            sqlCommand.CommandText = passwordUpdate;
            sqlCommand.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }


    
}
