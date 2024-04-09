using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestClass
    {
        public static void Main()
        {
            try
            {
                Customer Yc = new Customer(001, "YangCheng");
                Goods Water = new Goods(001, "water", 2.00f);
                Goods Bread = new Goods(002, "bread", 4.00f);
                Goods Pen = new Goods(003, "pen", 1.00f);
                Goods Paper = new Goods(004, "paper", 0.50f);
                Order order1 = new Order(00001, Yc, new DateTime(2024, 4, 2));
                order1.AddDetails(new OrderDetail(Water, 2));
                order1.AddDetails(new OrderDetail(Pen, 4));
                order1.AddDetails(new OrderDetail(Paper, 10));

                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);

                //测试各个方法(包括OrderService参考了部分示例代码）
                Console.WriteLine("GetById");
                Console.WriteLine(orderService.GetById(00001));

                Console.WriteLine("GetAllOrders");
                List<Order> orders = orderService.QueryAll();
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("GetOrdersByCustomerName:'YangCheng'");
                orders = orderService.QueryByCustomerName("YangCheng");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("GetOrdersTotalAmount:1000");
                orders = orderService.QueryByTotalPrice(1000);
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("GetOrdersTotalAmount:13");
                orders = orderService.QueryByTotalPrice(13);
                orders.ForEach(o => Console.WriteLine(o));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
