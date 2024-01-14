using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace coffeeshop
{
    

    public partial class Form1 : Form
    {
        
        //주문데이터 저장 변수 
        List<OrderData> totalOrder;
        OrderData orderData;
        //주문ID(주문자 별로 발생) 주문detailID(메뉴 별로 발생)
        private static int s_orderIDSeed = 1000;


        //DB연결 
        string sConn =$"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vests\\source\\repos\\coffeeshopApp\\coffeeshop\\orderListDB.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        

        public Form1()
        {
            InitializeComponent();

            //DB 연결 
            sqlConnect.ConnectionString = sConn;
            sqlConnect.Open();
            sqlCommand.Connection = sqlConnect;

        }

        private void welcomeImgBtn_Click(object sender, EventArgs e)
        {
            orderData = new OrderData(s_orderIDSeed, flag_increase_seed.Yes);
            //결제하기 됐을 때 , s_orderIDSeed++;
            totalOrder = new List<OrderData>(); 
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

        private void overlappingMenusAreCombined() {

            //이름순 정렬 
            totalOrder.Sort(delegate (OrderData x, OrderData y)
            {
                return x.menuName.CompareTo(y.menuName);
            });
        }

        private void dialogResultCheck(ref menuSelected menuSpec) {
            if (DialogResult.OK == menuSpec.ShowDialog())
            {
                //사용자가 선택한 메뉴 구체사항(메뉴 이름, HOT/COLD, SIZE, 수량 ) 정보 전달
                orderData.menuName = menuSpec.subOrder.menuName;
                orderData.hotCold = menuSpec.subOrder.hotCold;
                orderData.size = menuSpec.subOrder.size;
                orderData.count = menuSpec.subOrder.count;
                //OrderData newOrder = orderData.Copy();
                //위의 메소드를 사용 안하는  이유: 메뉴 세부사항 선택이 끝난후,주문내역에 추가될 때, 
                //orderDetailId가 증가하면서 인스턴스화 해야 하기 때문에  
                
                //orderData = newOrder 데이터 내용 (*orderDetailID 제외 )일일이 복사 
                OrderData newOrder = new OrderData(s_orderIDSeed, flag_increase_seed.Yes);
                newOrder.take = orderData.take;
                newOrder.menuName = orderData.menuName;
                newOrder.hotCold = orderData.hotCold;
                newOrder.size = orderData.size; 
                newOrder.count = orderData.count;   


                totalOrder.Add(newOrder);//최종 주문 내역에 추가 
                overlappingMenusAreCombined();

                orderListTb.Text = "";
                menuListLb.Text = "";
                foreach (OrderData item in totalOrder)
                {
                    menuListLb.Text += item.orderID +","
                        + item.orderDetailID + ","
                        + item.take + ","
                        + item.menuName + ","
                        + item.hotCold + ","
                        + item.size + ","
                        + item.count + "\r\n";
                }



                //orderListTb.Text += orderData.menuName + "\t"
                //    + orderData.hotCold + "\t"
                //    + orderData.size + "\t"
                //    + orderData.count + "\t\r\n";

                // 주문세부ID(orderDetailID), 먹고가기/포장(take)정보를 제외하고는 초기화  
                orderData.menuName = string.Empty;
                orderData.hotCold = string.Empty;   
                orderData.size = string.Empty;
                orderData.count = 0;

                //주문메뉴 중복 체크 함수 추가 


                MessageBox.Show("장바구니 담기 완료");

            }
            else
            {
                MessageBox.Show("오류발생, 재입력 필요");
            }
        }

        private void ameBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Ame, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }

        private void latBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Lat, orderData.orderID);
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

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = payTab;
            

            StringBuilder sb = new StringBuilder();
            sqlCommand.CommandText = "SELECT * FROM item_price";

            // SqlDataReader 객체를 리턴
            SqlDataReader rdr = sqlCommand.ExecuteReader();

            // 다음 레코드 계속 가져와서 루핑
            while (rdr.Read())
            {
                // C# 인덱서를 사용하여
                // 필드 데이타 엑세스
                //string s = rdr["menu_name"] as string;
                string s = rdr["menu_name"].ToString()+"\b"+ rdr["size"].ToString() + "\t" + rdr["price"].ToString()+"\r\n";
                sb.Append(s);
            }
            // 사용후 닫음
            rdr.Close();

            pay_priceLb.Font = new System.Drawing.Font("D2Coding", 24F);
            pay_priceLb.Text = sb.ToString();
        }
    }

}
