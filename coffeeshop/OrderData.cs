using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop
{
    public enum flag_increase_seed{ Yes, No };
    public class OrderData
    {
        public int orderID { get; set; }
        private static int s_orderDetailIDSeed = 0;
        public int orderDetailID { get; set; }  //주문상세id번호     
        public string take { get; set; }//테이크아웃 인
        public string menuName{ get; set; }//메뉴이름
        public string hotCold { get; set; }// 핫콜드
        public string size { get; set; }//사이즈
        public int quantity { get; set; }//갯수 

        //public int orderDetailID;// { get; }
        //public string take;// { get; set; }//테이크아웃 인
        //public string menuName; //{ get; set; }//메뉴이름
        //public string hotCold;// { get; set; }// 핫콜드
        //public string size;// { get; set; }//사이즈
        //public int count;//갯수 

        public OrderData(int orderid, flag_increase_seed answer)
        {
            orderID = orderid;            
            if (answer == flag_increase_seed.Yes)
            {
                orderDetailID = s_orderDetailIDSeed;
                s_orderDetailIDSeed++;
            }
            else if (answer == flag_increase_seed.No) {
                orderDetailID = s_orderDetailIDSeed - 1;
            }            
            take = "";
            menuName = "";  
            hotCold = "";
            size = "";
            quantity = 0;
        }

        public OrderData Copy() { return (OrderData) this.MemberwiseClone(); }
    }
}
