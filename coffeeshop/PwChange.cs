using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class pwChange : Form
    {
        public pwChange()
        {
            InitializeComponent();
        }

        public string GetNewPw()
        {
            return newPw.Text;
        }

        public string GetConfirmPw()
        { 
            return confirmPw.Text;
        }
        
        private void Ok_Click(object sender, EventArgs e)
        {
            if (newPw.Text == confirmPw.Text)
            {                
                MessageBox.Show("비밀번호가 성공적으로 변경되었습니다");
                this.Close();
            }
            else
            {
                MessageBox.Show("새 비밀번호가 서로 일치하지 않습니다");
            }
            
        }

    }            

}
