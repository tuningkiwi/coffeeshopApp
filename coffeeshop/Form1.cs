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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace coffeeshop
{


    public partial class Form1 : Form
    {


        //List<OrderData> totalOrder; 미사용 변수
        
        //주문데이터 저장 변수 
        OrderData orderData;
        
        //주문ID(주문자 별로 발생) 주문detailID(메뉴 별로 발생)
        private static int s_orderIDSeed = 1000;

        //DB연결 
        string sConn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vests\source\repos\coffeeshopApp\coffeeshop\order_list_DB.mdf;Integrated Security=True;Connect Timeout=30";
        //string sConn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EMBEDDED\source\repos\coffeeshopApp\coffeeshop\kioskData.mdf;Integrated Security=True;Connect Timeout=30";
        //string sConn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EMBEDDED\source\repos\coffeeshopApp\DBDATA.mdf;Integrated Security=True;Connect Timeout=30";
        


        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();

        public Form1()
        {
            InitializeComponent();

            //dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("D2Coding", 18F);               dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("D2Coding", 24F);
           

            //DB 연결 
            sqlConnect.ConnectionString = sConn;
            sqlConnect.Open();
            sqlCommand.Connection = sqlConnect;

            forHereBtn.Bounds = new Rectangle(new Point(Width * 1 / 5, Height * 1 / 3), new Size(Width * 1 / 5, Height * 1 / 3));
            toGoBtn.Bounds = new Rectangle(new Point(Width * 3 / 5, Height * 1 / 3), new Size(Width * 1 / 5, Height * 1 / 3));

            splitContainer1.SplitterDistance = Height * 3 / 4;

        }


        /***************************************/
        //       웰컴 창                       //
        /***************************************/

        // 1번째 탭 : 웰컴창 
        private void welcomeImgBtn_Click(object sender, EventArgs e)
        {
            orderData = new OrderData(s_orderIDSeed, flag_increase_seed.Yes);
            //결제하기 됐을 때 , s_orderIDSeed++;
            //totalOrder = new List<OrderData>();
            orderTabCtrl.SelectedTab = takeOutTab;
        }

        /***************************************/
        //       먹고가기 / 포장하기 선택      //
        /***************************************/

        //2번째 탭 :먹고가기 버튼 
        private void forHereBtn_Click(object sender, EventArgs e)
        {
            orderData.take = "FORHERE";
            orderTabCtrl.SelectedTab = menuTab;
        }

        //2번째 탭 : 포장하기 버튼 
        private void toGoBtn_Click(object sender, EventArgs e)
        {
            orderData.take = "TOGO";
            orderTabCtrl.SelectedTab = menuTab;

        }


        /***************************************/
        //           메뉴선택                 //
        /***************************************/

        //메뉴창에서 아메리카노 선택한 경우
        private void ameBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Ame, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }

        //메뉴창에서 카페라떼 선택한 경우
        private void latBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Lat, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }

        //메뉴창에서 바닐라라떼 선택한 경우
        private void vlaBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Van, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }

        //메뉴창에서 로열밀크티 선택한 경우
        private void royalBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Roy, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }

        //메뉴창에서 스트로베리라떼 선택한 경우
        private void strawberrylatteBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Str, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }

        //메뉴창에서 블루베리요거트 선택한 경우
        private void blueyogurtBtn_Click(object sender, EventArgs e)
        {
            menuSelected menuSpec = new menuSelected(MenuID.Blu, orderData.orderID);
            dialogResultCheck(ref menuSpec);
        }


        //(현재 사용 안함) 주문 내역 이름 순 정렬 함수 
        //private void overlappingMenusAreCombined()
        //{

        //    //이름순 정렬 
        //    totalOrder.Sort(delegate (OrderData x, OrderData y)
        //    {
        //        return x.menuName.CompareTo(y.menuName);
        //    });
        //}


        /***************************************/
        //      메뉴 세부 사항(사이즈, 핫/콜드, 수량)
        //      선택창 종료한 후 처리          //
        /***************************************/

        // DB에 선택 데이터 저장, 주문 내역 보여주기   
        private void dialogResultCheck(ref menuSelected menuSpec)
        {
            DialogResult dResult = menuSpec.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                //사용자가 선택한 메뉴 구체사항(메뉴 이름, HOT/COLD, SIZE, 수량 ) 정보 전달
                orderData.menuName = menuSpec.subOrder.menuName;
                orderData.hotCold = menuSpec.subOrder.hotCold;
                orderData.size = menuSpec.subOrder.size;
                orderData.quantity = menuSpec.subOrder.quantity;


                //OrderData newOrder = orderData.Copy();
                //위의 메소드를 사용 안하는  이유: 메뉴 세부사항 선택이 끝난후,주문내역에 추가될 때, 
                //orderDetailId가 증가하면서 인스턴스화 해야 하기 때문에  

                //orderData = newOrder 데이터 내용 (*orderDetailID 제외 )일일이 복사 
                OrderData newOrder = new OrderData(s_orderIDSeed, flag_increase_seed.Yes);
                //label5.Text += $"{newOrder.orderDetailID}\r\n";
                newOrder.take = orderData.take;
                newOrder.menuName = orderData.menuName;
                newOrder.hotCold = orderData.hotCold;
                newOrder.size = orderData.size;
                newOrder.quantity = orderData.quantity;


                /*current_order_list table에 저장 */
                //선택한 항목이 기존의 주문내역에 존재하는지 여부 확인하기 
                sqlCommand.CommandText = $"select order_detail_id as id from current_order_list " +
                    $"where menu_name=N'{newOrder.menuName}' and hot_cold=N'{newOrder.hotCold}' and size=N'{newOrder.size}'";
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                int item = 0;
                while (rdr.Read())
                {
                    item = (Convert.ToInt16(rdr["id"].ToString()));
                }
                rdr.Close();

                // 기존 주문 내역에 선택한 항목이 있다면, 
                // DB를 업데이트 한다 
                if (item != 0)
                {//update 

                    string quantityUpdate = $"update current_order_list set quantity={newOrder.quantity} where order_detail_id={item}";
                    sqlCommand.CommandText = quantityUpdate;

                }
                else// 기존 주문 내역에 선택한 항목이 없다면, 
                { // 데이터 INSERT 

                    string sqlcmd = $"insert into current_order_list " +
                        $"(order_id, order_detail_id, take_out_in, menu_name, hot_cold,size,quantity) " +
                        $"values({newOrder.orderID}, {newOrder.orderDetailID}, N'{newOrder.take}', N'{newOrder.menuName}', N'{newOrder.hotCold}',N'{newOrder.size}',{newOrder.quantity})";

                    sqlCommand.CommandText = sqlcmd;

                }

                sqlCommand.ExecuteNonQuery();

                //totalOrder.Add(newOrder);//최종 주문 내역에 추가 
                //overlappingMenusAreCombined();//메뉴 정렬

                MessageBox.Show("장바구니 담기 완료");

            }
            else if (dResult == DialogResult.Cancel)
            {
                MessageBox.Show("주문 취소");
            }

            // 주문 내역 하단에 띄우기 
            sqlCommand.CommandText = $"select menu_name, hot_cold, size, quantity from current_order_list ";
            SqlDataReader rdr2 = sqlCommand.ExecuteReader();
            string orderContents = "주문내역\r\n";
            while (rdr2.Read())
            {
                orderContents += rdr2["menu_name"].ToString() + "     " + rdr2["hot_cold"].ToString() + "     "
                    + rdr2["size"].ToString() + "     " + rdr2["quantity"].ToString() + "\r\n";
            }
            rdr2.Close();
            menuListLb.Text = orderContents;

            // 추가 주문이 있을 경우를 대비해,
            // 주문세부ID(orderDetailID), 먹고가기/포장(take)정보를 제외하고는 초기화  
            orderData.menuName = string.Empty;
            orderData.hotCold = string.Empty;
            orderData.size = string.Empty;
            orderData.quantity = 0;


        }

        //현재 사용 안함 
        private StringBuilder saveDataInTable(string sqlcmd)
        {
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

        /***************************************/
        //         장바구니                    //
        /***************************************/
        //메뉴창에서 주문 선택 완료후, 장바구니 클릭시 구동 
        private void menu_cart_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = Width * 2 / 3;
            orderTabCtrl.SelectedTab = cartTab;


            string cmd =  "select cur.menu_name, cur.hot_cold, cur.size, it.price, cur.quantity from current_order_list cur INNER JOIN item_price it on cur.menu_name = it.menu_name and cur.size = it.size ";


            orderListShow(sender, e, cmd, dataGridView1);

            List<String> result = printTotal();
            totalCountLb.Font = new System.Drawing.Font("D2Coding", 24F);
            totalCountLb.Text = $"총{result[0]}개/   {result[1]}원";


        }



        /*************************************/
        //           결제하기                //
        /*************************************/
        //장바구니창에서 결제하기 클릭시 수행 
        private void paymentBtn_Click(object sender, EventArgs e)
        {
            orderTabCtrl.SelectedTab = payTab;

            pictureBox1.Image = new Bitmap(global::coffeeshop.Properties.Resources.PayQR2, new Size(500, 610));

            printTotal();
            List<String> result = printTotal();
            pay_priceLb.Font = new System.Drawing.Font("D2Coding", 24F);
            pay_priceLb.Text = $"총{result[0]}개/   {result[1]}원";

        }

        /*************************************/
        //           관리자모드               //
        /*************************************/
        // 로그인과 비밀번호 변경하기

        private void adminLogin_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = "select * from admin_id_pw";
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            string _password = ""; string _id = "";
            while (rdr.Read())
            {
                _id += rdr["id"].ToString();
                _password += rdr["password"].ToString();
            }
            rdr.Close();

            if (idBox.Text == _id && pwBox.Text ==_password)
            {
                // 로그인 성공
                MessageBox.Show("로그인 되었습니다");
                adminSec admin = new adminSec(_id);

                DialogResult dResult = admin.ShowDialog();
                if (dResult == DialogResult.OK)
                {

                }
            }
            else
            {
                // 로그인 실패
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다", "false", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*************************************/
        //           취소하기                //
        /*************************************/

        //취소하기를 누르거나 새로운 주문자가 나타났을 때, 데이터 클리어 
        private void dataClear() {
            //현재 주문 리스트 테이블 데이터 초기화 
            //새로운 주문자의 주문을 받기 위해서
            sqlCommand.CommandText = $"delete from current_order_list";
            sqlCommand.ExecuteNonQuery();

            menuListLb.Text = "주문내역";
            totalCountLb.Text = "총      0개/ 총      0원";
            pay_priceLb.Text = "총      0개/ 총      0원";

            //dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }

        //메뉴창에서  취소하기 
        private void goToBegin_Click(object sender, EventArgs e)
        {
            //s_orderIDSeed--;
            //delete current_data_list  클리어 
            dataClear();
            orderTabCtrl.SelectedTab = welcomeTab;
        }


        //장바구니에서 취소하면, 처음 화면으로 돌아가고 데이터 초기화 
        private void cart_cancelBtn_Click(object sender, EventArgs e)
        {
            //s_orderIDSeed--;
            dataClear();
            orderTabCtrl.SelectedTab = welcomeTab;

            //sql data delete 
            // 주문세부ID(orderDetailID), 먹고가기/포장(take)정보를 제외하고는 초기화

        }

        //결제창에서 취소하기
        private void pay_CancelBtn_Click(object sender, EventArgs e)
        {
            //s_orderIDSeed--;
            dataClear();
            orderTabCtrl.SelectedTab = welcomeTab;
        }


        /******************************************/
        //     주문자 최종 결제 완료                 //
        /*************************************/


        //주문자가 결제 완료 버튼 누를 경우,
        //주문이 확정되어 , 대기 중인 주문 리스트 DB로 이동하고
        //다음 주문자를 위한 기존 주문 데이터는 삭제된다. 
        private void payCompleted_Click(object sender, EventArgs e)
        {
            orderTabCtrl.SelectedTab = orderCompletedTab;

            //메뉴항목별 menu_id update
            sqlCommand.CommandText = $"update current_order_list set menu_id=it.menu_id from current_order_list cur INNER JOIN  item_price it on cur.menu_name=it.menu_name and cur.size=it.size;";
            sqlCommand.ExecuteNonQuery();

            /******결제가 완료되면, menu_id 업데이트와 현재 주문목록이 확정되어 처리대기중인 주문리스트로 복사됨  */
            sqlCommand.CommandText = $"insert into waiting_order_list ([order_id], [order_detail_id], [take_out_in],[menu_id], [menu_name], [hot_cold],[size],[quantity]) select order_id, order_detail_id, take_out_in, menu_id, menu_name, hot_cold, size, quantity from current_order_list";
            sqlCommand.ExecuteNonQuery();

            //주문 대기 번호 출력 
            sqlCommand.CommandText = $"select TOP 1 order_id from current_order_list"; 
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            string orderWaitingNumber = "";
            while (rdr.Read())
            {
                orderWaitingNumber = rdr["order_id"].ToString();
            }
            rdr.Close();

            orderNumberLb2.Text = orderWaitingNumber;

             //새 주문자 등장 
            s_orderIDSeed++;
            orderData.orderID = s_orderIDSeed;
            orderData.orderDetailID = 0;
            orderData.take ="";
            orderData.menuName = "";
            orderData.hotCold = "";
            orderData.size = "";
            orderData.quantity = 0;  

            //현재 주문 리스트 테이블 데이터 초기화 
            //새로운 주문자의 주문을 받기 위해서
            sqlCommand.CommandText = $"delete from current_order_list";
            sqlCommand.ExecuteNonQuery();  
            
            menuListLb.Text = "주문내역";
            totalCountLb.Text = "총      0개/ 총      0원";
            pay_priceLb.Text = "총      0개/ 총      0원";

            //dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }



        //**********주문 완료 후 기존 데이터 삭제 *******/
        private void completed_gotoStartBtn_Click(object sender, EventArgs e)
        {
            orderNumberLb2.Text = ".";
            //웰컴 창으로 이동 
            orderTabCtrl.SelectedTab = welcomeTab;     
        }


        //총 주문 갯수 및 결제(예정) 금액 출력 
        public List<String> printTotal()
        {
            sqlCommand.CommandText = "select sum(quantity) as total_count from current_order_list";
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            String strCount = "", strPrice = "";
            while (rdr.Read())
            {
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

            List<String> result = new List<String>();
            result.Add(strCount);
            result.Add(strPrice);

            return result;

            

        }

        /// <summary>
        /// SQL 처리 문과 Data grid view 에서 사용자 동작 처리 
        /// 장바구니 내역에서 최종적으로 사용자가 주문 내역을 변경하고
        /// DB 테이블 데이터도 업데이트가 이루어진다 
        /// </summary>


        //SQL 쿼리 처리 함수 
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
                }


                while (sr.Read())
                { //한줄씩 읽어서 처리를 해라 
                    object[] oarr = new object[sr.FieldCount];
                    sr.GetValues(oarr);
                    result.Add(oarr);
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
        public void orderListShow(object sender, EventArgs e, string cmd, DataGridView _gridView)
        {


            /*주문내역 SHOW */
            string sql = cmd;
            List<object[]> result = RunSql(sql);
            if (result == null) return;

            //_gridView.DataSource = null;
            _gridView.Rows.Clear();
            _gridView.Columns.Clear();


            for (int i = 0; i < ColName.Count - 1; i++)
            {
                //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                //데이터뷰에 컬럼 생성
                string _colName = ColName[i].ToString();
                _gridView.Columns.Add(_colName, _colName);


            }

            DataGridViewButtonColumn quantityControl = new DataGridViewButtonColumn();
            quantityControl.HeaderText = "차감";
            quantityControl.Text = "-";
            quantityControl.Name = "Sub";
            quantityControl.UseColumnTextForButtonValue = true;
            _gridView.Columns.Add(quantityControl);

            //quantity
            string colName = ColName[4].ToString();
            _gridView.Columns.Add(colName, colName);

            //+버튼 
            DataGridViewButtonColumn quantityControl2 = new DataGridViewButtonColumn();
            //quantityControl.Width =
            quantityControl2.HeaderText = "증감";
            quantityControl2.Text = "+";
            quantityControl2.Name = "Add";
            quantityControl2.UseColumnTextForButtonValue = true;
            _gridView.Columns.Add(quantityControl2);

            //x버튼 
            //+버튼 
            DataGridViewButtonColumn quantityControl3 = new DataGridViewButtonColumn();
            //quantityControl.Width =
            quantityControl3.HeaderText = "삭제";
            quantityControl3.Text = "삭제";
            quantityControl3.Name = "Del";
            quantityControl3.UseColumnTextForButtonValue = true;
            _gridView.Columns.Add(quantityControl3);


            //데이터 그리드 row column 크기 조정 불가 
            _gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _gridView.AllowUserToResizeColumns = false;
            _gridView.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _gridView.AllowUserToResizeRows = false;
            _gridView.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            _gridView.ReadOnly = true;


            for (int i = 0; i < _gridView.Columns.Count; i++)
            {
                _gridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                _gridView.Columns[i].Resizable = DataGridViewTriState.False;
                _gridView.Columns[i].ReadOnly = true;

                //그리드 셀 내용 오른쪽 정렬 
                _gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                _gridView.DefaultCellStyle.Font = new Font("D2Coding", 18);
                
                
            }


            for (int i = 0; i < result.Count; i++)
            {
                //sr로부터 i번째 col 의 값을 가져오고 
                int nRow = _gridView.Rows.Add();
                
                object[] row = result[i];
                for (int j = 0; j < row.Count() - 1; j++)
                {
                    _gridView.Rows[nRow].Cells[j].Value = row[j];

                }
                //quantity 
                _gridView.Rows[nRow].Cells[5].Value = row[4];
            }

        }


        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sub_dataGridView_CellClick(sender, e, dataGridView1);

            string cmd = "select cur.menu_name, cur.hot_cold, cur.size, it.price, cur.quantity" +
               " from current_order_list cur " +
               "INNER JOIN item_price it on cur.menu_name = it.menu_name and cur.size = it.size ";

            orderListShow(sender, e, cmd, dataGridView1);

            List<String> result = printTotal();
            totalCountLb.Font = new System.Drawing.Font("D2Coding", 24F);
            totalCountLb.Text = $"총{result[0]}개/   {result[1]}원";

        }

        //출력된 주문 내역 리스트에서 수량 + 또는 - 를 클릭했을 때 
        //DB 테이블 상에서도 같이 수정 처리 
        public void sub_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e, DataGridView _gridView)
        {

            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0) { return; }

            //+버튼 눌렀을 때 update 
            if (e.ColumnIndex == _gridView.Columns["Add"].Index)
            {//6번 
                string _m_name = (string)_gridView[0, e.RowIndex].Value;
                string _hot_cold = (string)_gridView[1, e.RowIndex].Value;
                string _size = (string)_gridView[2, e.RowIndex].Value;
                string quantityAdd = $"update current_order_list set quantity=quantity+1 " +
                    $"where menu_name=N'{_m_name}' and hot_cold =N'{_hot_cold}' and size=N'{_size}'";
                sqlCommand.CommandText = quantityAdd;
                sqlCommand.ExecuteNonQuery();

            }//- 버튼 눌렀을 때 update 
            else if (e.ColumnIndex == _gridView.Columns["Sub"].Index)
            {
                string _m_name = (string)_gridView[0, e.RowIndex].Value;
                string _hot_cold = (string)_gridView[1, e.RowIndex].Value;
                string _size = (string)_gridView[2, e.RowIndex].Value;
                int _quantity = (int)_gridView[5, e.RowIndex].Value;

                if (_quantity == 1) { return; }//0으로가면 안됨 
                string quantitySub = $"update current_order_list set quantity=quantity-1 " +
                $"where menu_name=N'{_m_name}' and hot_cold =N'{_hot_cold}' and size=N'{_size}'";
                sqlCommand.CommandText = quantitySub;
                sqlCommand.ExecuteNonQuery();

            }
            else if (e.ColumnIndex == _gridView.Columns["Del"].Index)
            {
                string _m_name = (string)_gridView[0, e.RowIndex].Value;
                string _hot_cold = (string)_gridView[1, e.RowIndex].Value;
                string _size = (string)_gridView[2, e.RowIndex].Value;
                string quantityDel = $"delete from current_order_list " +
                $"where menu_name=N'{_m_name}' and hot_cold =N'{_hot_cold}' and size=N'{_size}'";
                sqlCommand.CommandText = quantityDel;
                sqlCommand.ExecuteNonQuery();

            }

        }

    }


}
