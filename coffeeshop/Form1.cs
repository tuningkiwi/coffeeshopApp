using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        //string sConn =$"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vests\\source\\repos\\coffeeshopApp\\coffeeshop\\orderListDB.mdf;Integrated Security = True; Connect Timeout = 30";
        string sConn =$@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EMBEDDED\source\repos\coffeeshopApp\coffeeshop\orderListDB.mdf;Integrated Security=True;Connect Timeout=30";


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


        //  dialog  메뉴 세부 사항 선택창 종료하고, 부모 창에 데이터 전달 
        private void dialogResultCheck(ref menuSelected menuSpec) {
            if (DialogResult.OK == menuSpec.ShowDialog())
            {
                //사용자가 선택한 메뉴 구체사항(메뉴 이름, HOT/COLD, SIZE, 수량 ) 정보 전달
                orderData.menuName = menuSpec.subOrder.menuName;
                orderData.hotCold = menuSpec.subOrder.hotCold;
                orderData.size = menuSpec.subOrder.size;
                orderData.quantity  = menuSpec.subOrder.quantity;
                

                //OrderData newOrder = orderData.Copy();
                //위의 메소드를 사용 안하는  이유: 메뉴 세부사항 선택이 끝난후,주문내역에 추가될 때, 
                //orderDetailId가 증가하면서 인스턴스화 해야 하기 때문에  

                //orderData = newOrder 데이터 내용 (*orderDetailID 제외 )일일이 복사 
                OrderData newOrder = new OrderData(s_orderIDSeed, flag_increase_seed.Yes);
                newOrder.take = orderData.take;
                newOrder.menuName = orderData.menuName;
                newOrder.hotCold = orderData.hotCold;
                newOrder.size = orderData.size;
                newOrder.quantity = orderData.quantity;


                /*current_order_list table에 저장 */
                //동일항목 확인하기 
                sqlCommand.CommandText = $"select order_detail_id as id from current_order_list " +
                    $"where menu_name=N'{newOrder.menuName}' and hot_cold=N'{newOrder.hotCold}' and size=N'{newOrder.size}'";
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                int item = 0;
                while (rdr.Read())
                {
                   item= (Convert.ToInt16(rdr["id"].ToString()));
                }
                rdr.Close();

                
                if (item != 0)
                {//update 
                    
                    string quantityUpdate = $"update current_order_list set quantity={newOrder.quantity} where order_detail_id={item}";
                    sqlCommand.CommandText = quantityUpdate;
                    
                }
                else
                { // INSERT 
                    //menuListLb.Text += "동일 항목없음";
                   
                    string sqlcmd = $"insert into current_order_list " +
                        $"(order_id, order_detail_id, take_out_in, menu_name, hot_cold,size,quantity) " +
                        $"values({newOrder.orderID}, {newOrder.orderDetailID}, N'{newOrder.take}', N'{newOrder.menuName}', N'{newOrder.hotCold}',N'{newOrder.size}',{newOrder.quantity})";

                    sqlCommand.CommandText = sqlcmd;
               
                }
                
                sqlCommand.ExecuteNonQuery();
                

                totalOrder.Add(newOrder);//최종 주문 내역에 추가 
                overlappingMenusAreCombined();

                sqlCommand.CommandText = $"select menu_name, hot_cold, size, quantity from current_order_list ";
                SqlDataReader rdr2 = sqlCommand.ExecuteReader();
                string orderContents = "";
                while (rdr2.Read())
                {
                    orderContents += rdr2["menu_name"].ToString() + "     "+ rdr2["hot_cold"].ToString() + "     "
                        + rdr2["size"].ToString() + "     " + rdr2["quantity"].ToString() + "\r\n";
                }
                rdr2.Close();
                menuListLb.Text = orderContents;

                //foreach (OrderData it in totalOrder)
                //{
                //    orderContents += it.menuName + "     " + it.hotCold + "     "
                //       + it.size + "     " + it.quantity + "\r\n";
                //}

                // 주문세부ID(orderDetailID), 먹고가기/포장(take)정보를 제외하고는 초기화  
                orderData.menuName = string.Empty;
                orderData.hotCold = string.Empty;
                orderData.size = string.Empty;
                orderData.quantity = 0;
                //주문메뉴 중복 체크 함수 추가 

                MessageBox.Show("장바구니 담기 완료");

            } else if (DialogResult.Cancel == menuSpec.ShowDialog()) { 
                
            }
            else
            {
                MessageBox.Show("오류발생, 재입력 필요");
            }
        }

        private StringBuilder saveDataInTable(string sqlcmd) {
            StringBuilder sb = new StringBuilder();
            sqlCommand.CommandText = sqlcmd;

            SqlDataReader rdr = sqlCommand.ExecuteReader();

            // 다음 레코드 계속 가져와서 루핑
            while (rdr.Read())
            {
                // C# 인덱서를 사용하여
                // 필드 데이타 엑세스
                //string s = rdr["menu_name"] as string;
                string s = rdr["menu_name"].ToString() + "\b" + rdr["size"].ToString() + "\t" + rdr["price"].ToString() + "\r\n";
                sb.Append(s);
            }
            // 사용후 닫음
            rdr.Close();
            return sb;  
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
            splitContainer1.SplitterDistance = Width*2/3;
            tabControl.SelectedTab = cartTab;
            
            dataGridView1.DefaultCellStyle.Font = new Font("D2Coding", 18);
            paymentBtn.Bounds = new Rectangle(new Point(200,600), new Size(200, 120));
            orderListShow(sender,e);

            sqlCommand.CommandText = "select sum(quantity) as total_count from current_order_list";
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            String strCount="", strPrice="";
            while (rdr.Read()) {
                strCount += rdr["total_count"].ToString();
            }
            rdr.Close();


            sqlCommand.CommandText = "select sum(it.price*cur.quantity) as total_price from current_order_list cur INNER JOIN item_price it on cur.menu_name = it.menu_name and cur.size = it.size ";
            SqlDataReader rdr2 = sqlCommand.ExecuteReader();
            
            while (rdr2.Read())
            {
                strPrice += rdr2["total_price"].ToString();
            }       
            rdr2.Close();

            //주문 총 잔수/ 총액 
            totalCountLb.Text = $"총{strCount}개/   {strPrice}원";

        }

        

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = payTab;

            string sqlcmd = "SELECT * FROM item_price";
            StringBuilder sb = saveDataInTable(sqlcmd);

            pay_priceLb.Font = new System.Drawing.Font("D2Coding", 24F);
            pay_priceLb.Text = sb.ToString();
        }


        ArrayList ColName = new ArrayList();
        List<object[]> RunSql(string sql)
        {
            //List<object[]> result = new List<object[]> { };
            List<object[]> result = new List<object[]>();

            sqlCommand.CommandText = sql;

            if (sql.Trim().ToLower().Substring(0, 6) == "select")
            {
                SqlDataReader sr = sqlCommand.ExecuteReader();
                //열의 갯수만큼 반복함 
                ColName.Clear();//이전 sql처리문에 의한 컬럼 정보 삭제 
                for (int i = 0; i < sr.FieldCount; i++)
                {
                    ColName.Add(sr.GetName(i));
                    //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름
                    //데이터뷰에 컬럼 생성
                    //dataView.Columns.Add(colName, colName);
                }


                while (sr.Read())
                { //한줄씩 읽어서 처리를 해라 
                    object[] oarr = new object[sr.FieldCount];
                    sr.GetValues(oarr);
                    result.Add(oarr);

                    //string str = "";
                    //int nRow = dataView.Rows.Add(); //row1개 추가, row가 몇개 생성됐는지 return     
                    //for (int i = 0; i < sr.FieldCount; i++)
                    //{
                    //    //sr로부터 i번째 col 의 값을 가져오고 
                    //    object obj = sr.GetValue(i);
                    //    //if (i == 0) str = $"{obj}";
                    //    if (i == 0) str = obj.ToString();
                    //    else
                    //    {
                    //        str = ","+ obj.ToString();
                    //    }

                    //    //dataview 어디에 저장할지 설정
                    //    dataView.Rows[nRow].Cells[i].Value = obj;
                    //}
                }
                sr.Close();

            }
            else
            {//insert update delete 
                int n = sqlCommand.ExecuteNonQuery();
            }

            //sbLabel3.Text = "Excute OK";
            return result;
        }


        // CART TAB  DATA GRID VIEW 
        private void orderListShow(object sender, EventArgs e)
        {


            /*주문내역 SHOW */
            string sql = "select cur.menu_name, cur.hot_cold, cur.size, cur.quantity, " +
                "it.price, it.price*cur.quantity as total from current_order_list cur " +
                "INNER JOIN item_price it on cur.menu_name = it.menu_name and cur.size = it.size ";

            try
            {
                List<object[]> result = RunSql(sql);
                if (result == null) return;


                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();


                for (int i = 0; i < ColName.Count; i++)
                {
                    string colName = ColName[i].ToString();

                    //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                    //데이터뷰에 컬럼 생성
                    dataGridView1.Columns.Add(colName, colName);
                }

                DataGridViewButtonColumn quantityControl = new DataGridViewButtonColumn();
                //quantityControl.Width =
                quantityControl.HeaderText = "수량조절";
                quantityControl.Text = "-";
                quantityControl.Name = "quantitySubtract";
                quantityControl.UseColumnTextForButtonValue = true; 
                dataGridView1.Columns.Add(quantityControl);
                   
                


                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dataGridView1.ReadOnly = true;



                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
                    dataGridView1.Columns[i].ReadOnly = true;

                    if (i == 0) { dataGridView1.Columns[i].Width = 200; }
                    else {
                        dataGridView1.Columns[i].Width = 150;   
                    }
                    //dataGridView1.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                }


                for (int i = 0; i < result.Count; i++)
                {
                    //sr로부터 i번째 col 의 값을 가져오고 
                    int nRow = dataGridView1.Rows.Add();
                    object[] row = result[i];
                    for (int j = 0; j < row.Count(); j++)
                    {
                        //dataview 어디에 저장할지 설정
                        dataGridView1.Rows[nRow].Cells[j].Value = row[j];
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void totalCountLb_Click(object sender, EventArgs e)
        {

        }
    }

}
