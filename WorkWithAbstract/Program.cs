using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderAbstraction order;
            while (true)
            {
                Console.WriteLine("please enter the order type: ");
                int orderType = Convert.ToInt32(Console.ReadLine());
                if (orderType==(int)Utility.OrderType.FinishedOrder)
                {
                    break;
                }
                else
                {
                    switch (orderType)
                    {
                        case (int)Utility.OrderType.GadgetOrder:
                            order = new GedgetOrder();
                            break;
                        case (int)Utility.OrderType.FoodOrder:
                            order = new FoodOrder();
                            break;
                        default:
                            order = null;
                            break;
                    }
                    var obj = new Order
                    {
                        CustomerId = "C001",
                        OrderId = Guid.NewGuid(),
                        OrderDate = DateTime.Now,
                        Amount = 10000,
                    };
                    order.CreateOrder(obj);
                    foreach (var item in order.GetList())
                    {
                        Console.WriteLine($"Order Id: {item.OrderId}, Customer Id:{item.CustomerId}, Amount: {item.Amount}");
                    }
                }

            }
            

        }
    }
}
