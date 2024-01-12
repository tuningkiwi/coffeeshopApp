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
    typedef struct Order
    {
        string orderId;//주문번호
        string take;//테이크아웃 인
        string menuName;//메뉴이름
        string hotORcold;// 핫콜드
        string size;//사이즈
        int count;//갯수 
    };

public partial class Form1 : Form
    {
        List<struct Order> data = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void welcomeImgButton_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = takeOutTab;
        }

        private void forHereBtn_Click(object sender, EventArgs e)
        {
        string takeout = "out";   
        }
    }
}
