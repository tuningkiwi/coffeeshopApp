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
    public partial class adminSec : Form
    {
        public adminSec()
        {
            InitializeComponent();
        }

        Form1 frm = new Form1();

        private void waitingListBtn_Click(object sender, EventArgs e)
        {
            dataGridView_admin.DefaultCellStyle.Font = new Font("D2Coding", 18);

            string cmd =  "select * from waiting_order_list";
            frm.orderListShow(sender, e, cmd, dataGridView_admin);

            List<String> result = frm.printTotal();
            totalSalesBtn.Font = new System.Drawing.Font("D2Coding", 24F);
            totalSalesBtn.Text = $"총{result[0]}개/   {result[1]}원";

           
        }

        private void dataGridView_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm.sub_dataGridView_CellClick(sender, e, dataGridView_admin);

            string cmd = "select * from waiting_order_list";

            frm.orderListShow(sender, e, cmd, dataGridView_admin);

            List<String> result = frm.printTotal();
            totalSalesBtn.Font = new System.Drawing.Font("D2Coding", 24F);
            totalSalesBtn.Text = $"총{result[0]}개/   {result[1]}원";
        }

    }
}
