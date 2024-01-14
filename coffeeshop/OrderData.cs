using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop
{
    public class OrderData
    {
        private static int s_orderIdSeed = 0;//주문번호
        public int orderId;// { get; }
        public string take;// { get; set; }//테이크아웃 인
        public string menuName; //{ get; set; }//메뉴이름
        public string hotCold;// { get; set; }// 핫콜드
        public string size;// { get; set; }//사이즈
        public int count;//갯수 

       public OrderData()
        {
            orderId = s_orderIdSeed;
            s_orderIdSeed++;
            take = string.Empty;
            menuName = string.Empty;  
            hotCold = string.Empty;
            size = string.Empty;
            count = 0;
        }
    }
}
