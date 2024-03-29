﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public enum showList { waiting_list, completed_list };

    public partial class adminSec : Form
    {
        //Form1 frm = new Form1();
        string sConn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vests\source\repos\coffeeshopApp2\code\coffeeshopApp\order_list_DB.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();

        bool waitListInDataGridView = true; //false: completed order list를 data grid view에서 보여줌.  
        public adminSec(string userId)
        {
            InitializeComponent();

            //DB 연결 
            sqlConnect.ConnectionString = sConn;
            sqlConnect.Open();
            sqlCommand.Connection = sqlConnect;


            idWelcomeLb.Text = $"{userId}님, 환영합니다";

            bell_1.Visible = false;
            bell_2.Visible = false;
            bell_3.Visible = false;
            bell_4.Visible = false;
            bell_5.Visible = false;

        }

        //현재 대기 중인 주문 내역을 보여준다 
        private void waitingListBtn_Click(object sender, EventArgs e)
        {
            waitListInDataGridView = true; 
            dataGridView_admin.DefaultCellStyle.Font = new Font("D2Coding", 18);

            string cmd = "select * from waiting_order_list ";
            //frm.orderListShow(sender, e, cmd, dataGridView_admin);
            orderListShow(showList.waiting_list, cmd, dataGridView_admin);

            //처리해야할 주문자 수/ 주문잔수
            printTotal(sender);


        }

        //주문자가 픽업완료함 주문 리스트 출력 
        private void completedListBtn_Click(object sender, EventArgs e)
        {
            waitListInDataGridView = false;

            string cmd = "select *, (it.price*quantity) as total_price " +
                "from completed_order_list com INNER JOIN  item_price it " +
                "on com.menu_id=it.menu_id order by order_id, order_detail_id";
            orderListShow(showList.completed_list, cmd, dataGridView_admin);

            //총 매출 
            printTotal(sender);

        }


        // 사장님이 주문이 완성되고, 완료 버튼을 누를 때,
        // 대기중인 주문 내역에서 삭제되고, 완료된 주문 리스트로 이동한다 
        private void dataGridView_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (waitListInDataGridView == false) { return; }
            sub_dataGridView_CellClick(sender, e, dataGridView_admin);

            string cmd = "select * from waiting_order_list";

            orderListShow(showList.waiting_list, cmd, dataGridView_admin);
            printTotal(sender);

        }

        public void sub_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e, DataGridView _gridView)
        {

            // Ignore clicks that are not on button cells. 
            //if (e.RowIndex < 0) { return; }
            //처리 완료 버튼을 눌렀을 시
            if (e.ColumnIndex == _gridView.Columns["Del"].Index)
            {
                Int32 _order_detail_id = (Int32)_gridView[1, e.RowIndex].Value;
                Int32 _order_id = (Int32)_gridView[0, e.RowIndex].Value;

                //제조 완료된 주문 항목은 completed_order_list로 이동한다 
                string copyToCompletedOrderList = $"insert into completed_order_list (order_id, order_detail_id, take_out_in, menu_id, hot_cold, quantity) "+
                    $" select order_id, order_detail_id, take_out_in, menu_id, hot_cold, quantity from waiting_order_list  where order_detail_id={_order_detail_id} and order_id={_order_id}";
                sqlCommand.CommandText = copyToCompletedOrderList;
                sqlCommand.ExecuteNonQuery();

                //제조완료된 주문 항목은 삭제한다 
                string quantityDel = $"delete from waiting_order_list where order_detail_id={_order_detail_id} and order_id={_order_id}";
                sqlCommand.CommandText = quantityDel;
                sqlCommand.ExecuteNonQuery();
                printTotal(sender);

            }
                     
        }

        // 매출 총액 출력 
        public void printTotal(object sender)
        {
            totalSalesBtn.Font = new System.Drawing.Font("D2Coding", 24F);

            if (sender == completedListBtn)
            {
                sqlCommand.CommandText = "select sum (it.price*quantity) as total_sales " +
                    "from completed_order_list com INNER JOIN  item_price it " +
                    "on com.menu_id=it.menu_id";
                SqlDataReader rdr2 = sqlCommand.ExecuteReader();
                int total_sales = 0;

                while (rdr2.Read())
                {
                    total_sales += int.Parse(rdr2["total_sales"].ToString());
                }
                rdr2.Close();

                totalSalesBtn.Text = $"총 매출 : {total_sales}원";
            }
            else //if (sender == waitingListBtn) 와 data grid view 상의 처리 완료 버튼  
            {
                sqlCommand.CommandText = "select sum(quantity) as total_cups from waiting_order_list";
                SqlDataReader rdr2 = sqlCommand.ExecuteReader();
                string strPrice = "";

                while (rdr2.Read())
                {
                    strPrice += rdr2["total_cups"].ToString();
                }
                rdr2.Close();

                totalSalesBtn.Text = $"대기 중인 주문 잔 수 : {strPrice}건";

            }
    
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


        // 현재 대기 중인 주문 리스트 확인 
        public void orderListShow(showList show, string cmd, DataGridView _gridView)
        {

            /*주문내역 SHOW */
            string sql = cmd;
            List<object[]> result = RunSql(sql);
            if (result == null) return;

            //_gridView.DataSource = null;
            _gridView.Rows.Clear();
            _gridView.Columns.Clear();


            for (int i = 0; i < ColName.Count; i++)
            {
                //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                //데이터뷰에 컬럼 생성
                string _colName = ColName[i].ToString();
                _gridView.Columns.Add(_colName, _colName);

            }

            if (show == showList.waiting_list) {
                // 처리 완료 버튼 
                DataGridViewButtonColumn quantityControl3 = new DataGridViewButtonColumn();

                quantityControl3.HeaderText = "처리완료";
                quantityControl3.Text = "완료";
                quantityControl3.Name = "Del";
                quantityControl3.UseColumnTextForButtonValue = true;
                _gridView.Columns.Add(quantityControl3);
            }


            //데이터 그리드 row column 크기 조정 불가 
            _gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _gridView.AllowUserToResizeColumns = true;
            _gridView.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _gridView.AllowUserToResizeRows = true;
            _gridView.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            _gridView.ReadOnly = true;


            for (int i = 0; i < _gridView.Columns.Count; i++)
            {
                _gridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                _gridView.Columns[i].Resizable = DataGridViewTriState.False;
                _gridView.Columns[i].ReadOnly = true;

                _gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                _gridView.DefaultCellStyle.Font = new Font("D2Coding", 18);


            }


            for (int i = 0; i < result.Count; i++)
            {
                //sr로부터 i번째 col 의 값을 가져오고 
                int nRow = _gridView.Rows.Add();

                object[] row = result[i];
                for (int j = 0; j < row.Count(); j++)
                {
                    _gridView.Rows[nRow].Cells[j].Value = row[j];

                }

            }

        }

        string StrComm = "";
        void OpenPort()
        {
            serialPort1.Open();
            sbLabel1.Text = StrComm;
            sbLabel1.BackColor = Color.Green;
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //read 
            string str = serialPort1.ReadExisting();
            AddText(str);
            belltobeOff();

        }


        delegate void AddTextCB(string str); // C/C++의 함수 포인터 개념
        void AddText(string str)
        {
            //Button stopBellNumber;

            if (bellNameLb.InvokeRequired)
            {
                AddTextCB cb = new AddTextCB(AddText);
                object[] arg = new object[] { str };
                Invoke(cb, arg);
            }
            else
            {
                bellNameLb.Text += str;

            }

        }

        void belltobeOff()
        {
            //bell.BackColor = SystemColors.Control;
            bellNameLb.Text += "iam here";
            switch (bellNameLb.Text)
            {
                case "bell num = 1": bell_1.BackColor = Color.Beige; break;
                case "bell num = 2": bell_2.BackColor = Color.Beige; break;
                case "bell num = 3": bell_3.BackColor = Color.Beige; break;
                case "bell num = 4": bell_4.BackColor = Color.Beige; break;
                case "bell num = 5": bell_5.BackColor = Color.Beige; break;

            }

        }


        private void portOpenBtn_Click(object sender, EventArgs e)
        {
            termConfig dlg = new termConfig(0, 0, 0, 0, 1);//초기값 전달 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                serialPort1.PortName = dlg.comPortBox.Text;
                serialPort1.BaudRate = int.Parse(dlg.baudRateBox.Text);

                //parity는 프로그램에 저장된 enum 타입이다
                //그래서 System.IO.Ports.Parity형으로 전환 필요 
                serialPort1.Parity = (System.IO.Ports.Parity)dlg.parityBox.SelectedIndex;
                serialPort1.DataBits = int.Parse(dlg.dataBitsBox.Text);
                serialPort1.StopBits = (System.IO.Ports.StopBits)dlg.stopBitsBox.SelectedIndex;
                //오픈 포트 명령 문자열 
                StrComm = $"{serialPort1.PortName}:{serialPort1.BaudRate}{dlg.parityBox.Text[0]}{serialPort1.DataBits}{dlg.dataBitsBox.Text}";
                OpenPort();

                bell_1.Visible = true;
                bell_2.Visible = true;
                bell_3.Visible = true;
                bell_4.Visible = true;
                bell_5.Visible = true;
            }
        }

        

        private void bell_1_Click(object sender, EventArgs e)
        {
            bell_1.BackColor = Color.LightSalmon;
            string sendCmd = "1";
            serialPort1.Write(sendCmd);
        }

        private void bell_2_Click(object sender, EventArgs e)
        {
            bell_2.BackColor = Color.LightSalmon;
            string sendCmd = "2";
            serialPort1.Write(sendCmd);
        }

        private void bell_3_Click(object sender, EventArgs e)
        {
            bell_3.BackColor = Color.LightSalmon;
            string sendCmd = "3";
            serialPort1.Write(sendCmd);
        }

        private void bell_4_Click(object sender, EventArgs e)
        {
            bell_4.BackColor = Color.LightSalmon;
            string sendCmd = "4";
            serialPort1.Write(sendCmd);
        }

        private void bell_5_Click(object sender, EventArgs e)
        {
            bell_5.BackColor = Color.LightSalmon;
            string sendCmd = "5";
            serialPort1.Write(sendCmd);
        }

        

        private void pwResetBtn_Click(object sender, EventArgs e)
        {
            changePassword changePWevent = new changePassword();  

            DialogResult dResult = changePWevent.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("비밀번호 재설정 완료");
            }
        }



    }


}
