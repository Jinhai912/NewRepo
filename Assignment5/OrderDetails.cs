using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderDetail
    {

        public Goods Goods { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice
        {
            get => Goods.Price * Quantity;
        }
        public OrderDetail() { }
        public OrderDetail(Goods goods, int quantity)
        {
            this.Goods = goods;
            this.Quantity = quantity;
        }
        public override string ToString()
        {
            return $"OrderDetail:{Goods},{Quantity}";
        }

    }
}
