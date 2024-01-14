using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{

    public partial class Form1 : Form
    {
        //List<OrderData> data;
        OrderData orderData;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void welcomeImgBtn_Click(object sender, EventArgs e)
        {
            orderData = new OrderData();
            tabControl.SelectedTab = takeOutTab;
        }

        private void forHereBtn_Click(object sender, EventArgs e)
        {
            orderData.take = "FORHERE";
            tabControl.SelectedTab = menuTab;
        }

        private void toGoBtn_Click(object sender, EventArgs e)
        {
            orderData.take = "TOGO";
            tabControl.SelectedTab = menuTab;
        }

        private void dialogResultCheck(ref menuSelected menuSpec) {
            if (DialogResult.OK == menuSpec.ShowDialog())
            {
                orderData.menuName = menuSpec.subOrder.menuName;
                orderData.hotCold = menuSpec.subOrder.hotCold;
                orderData.size = menuSpec.subOrder.size;
                orderData.count = menuSpec.subOrder.count;
                orderListTb.Text += orderData.menuName + "\t"
                    +orderData.hotCold +"\t"
                    + orderData.size +"\t"
                    + orderData.count +"\t\r\n";
                MessageBox.Show("장바구니 담기 완료");
            }
            else
            {
                MessageBox.Show("오류발생, 재입력 필요");
            }
        }

        private void ameBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Ame);
            dialogResultCheck(ref menuSpec);
        }

        private void latBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Lat);
            dialogResultCheck(ref menuSpec);
        }

        private void goToBegin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = takeOutTab;
        }

        private void menu_cart_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = cartTab;
        }
    }

}
