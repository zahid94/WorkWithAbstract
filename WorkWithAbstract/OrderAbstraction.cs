using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAbstract
{
    /*abstract class create for using to create set of rule ....for using a lot of user .they want same 
     * work but implementation separate*/
    public abstract class OrderAbstraction
    {
        public abstract Customer Registration(Customer customer);
        public abstract Order CreateOrder(Order order);
        public abstract List<Order> GetList();

        //We can create other common objects in abstract class as usual other classes
        public int Id { get; set; }

        public void TestMethod()
        {

        }
    }
}
