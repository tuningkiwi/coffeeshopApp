using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace coffeeshop
{
    public enum MenuID { Ame, Lat, Van, Str, Blu, Roy };

    public partial class menuSelected : Form
    {
        public OrderData subOrder;
        public menuSelected(MenuID mid, int orderID)
        {
            InitializeComponent();            
            nameLabel.Location = new Point(Width * 1 / 10, Height * 1 / 5 - 60);
            pictureBox1.Location = new Point(Width * 1 / 10, Height * 1 / 5);
            subOrder = new OrderData(orderID, flag_increase_seed.No);//데이터 전달용 
            
            subOrder.quantity = 0;
            switch (mid) { 
                case MenuID.Ame:                   
                    pictureBox1.Image = global::coffeeshop.Properties.Resources.americano;
                    //this.pictureBox1.ImageLocation = "0,0"; 이거 하면 안됨
                    nameLabel.Text = "아메리카노";
                    subOrder.menuName = "americano";
                    break;
                case MenuID.Lat:
                    pictureBox1.Image = global::coffeeshop.Properties.Resources.latte;
                    nameLabel.Text = "카페라떼";
                    subOrder.menuName = "caffe_latte";
                    break;
                case MenuID.Van:
                    pictureBox1.Image = global::coffeeshop.Properties.Resources.vanilalatte;
                    nameLabel.Text = "바닐라라떼";
                    subOrder.menuName = "vanila_latte";
                    break; 
                case MenuID.Str:
                    pictureBox1.Image = global::coffeeshop.Properties.Resources.strawberrylatte;
                    nameLabel.Text = "딸기퐁당라떼";
                    subOrder.menuName = "strawberry_latte";
                    HOT.Visible = false;
                    COLD.BackColor = Color.DodgerBlue;
                    subOrder.hotCold = "cold";
                    break;
                case MenuID.Blu:
                    pictureBox1.Image = global::coffeeshop.Properties.Resources.bluberryyogurt;
                    nameLabel.Text = "블루베리요거트";
                    subOrder.menuName = "blueberry_yogurt";
                    HOT.Visible = false;
                    COLD.BackColor = Color.DodgerBlue;
                    subOrder.hotCold = "cold";
                    break;
                case MenuID.Roy:
                    pictureBox1.Image = global::coffeeshop.Properties.Resources.roaylmilktea;
                    nameLabel.Text = "로열밀크티쉐이크";
                    subOrder.menuName = "royalmilktea";
                    HOT.Visible = false;
                    COLD.BackColor = Color.DodgerBlue;
                    subOrder.hotCold = "cold";
                    break;
                default:
                    break;
            }
            
            //Bitmap flag = new Bitmap(200, 100);
            //Graphics flagGraphics = Graphics.FromImage(flag);   
        }

        private void add_Click(object sender, EventArgs e)
        {
            subOrder.quantity++;
            countLabel.Text = subOrder.quantity.ToString();    
        }

        private void subtract_Click(object sender, EventArgs e)
        {

            if (subOrder.quantity > 0)
            {
                subOrder.quantity--;
                countLabel.Text = subOrder.quantity.ToString();
        
            }
        }

        private void HOT_Click(object sender, EventArgs e)
        {
            HOT.BackColor = Color.Red;           
            subOrder.hotCold = "hot";
            COLD.BackColor = Color.LightBlue;
        }

        private void COLD_Click(object sender, EventArgs e)
        {
            COLD.BackColor = Color.DodgerBlue;
            subOrder.hotCold = "cold";
            HOT.BackColor = Color.LightCoral;
        }

        private void SMALL_Click(object sender, EventArgs e)
        {
            SMALL.BackColor = Color.Orange;
            LARGE.BackColor = Color.Gainsboro;
            subOrder.size = "SMALL";
        }

        private void LARGE_Click(object sender, EventArgs e)
        {
            SMALL.BackColor = Color.Gainsboro;
            LARGE.BackColor = Color.Orange;
            subOrder.size = "LARGE";

        }

        private void cart_menuSelected_Click(object sender, EventArgs e)
        {
            //필수 선택항목 선택 안했을 경우 
            if (subOrder.hotCold == string.Empty || subOrder.size == string.Empty || subOrder.quantity == 0) {
                MessageBox.Show("HOT/COLD, 사이즈, 갯수 모두가 선택되야 합니다");
            } else {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void cancel_menuSelected_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
