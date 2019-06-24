using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAbstract
{
    public class FoodOrder : OrderAbstraction
    {
        public override Order CreateOrder(Order order)
        {
            order.OrderType = (int)Utility.OrderType.FoodOrder;
            order.Discount = Utility.FoodDiscount;
            Utility.OrderList.Add(order);
            return order;
        }

        public override List<Order> GetList()
        {
            List<Order> list = new List<Order>();
            foreach (Order item in Utility.OrderList)
            {
                if (item.OrderType == (int)Utility.OrderType.FoodOrder)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public override Customer Registration(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
