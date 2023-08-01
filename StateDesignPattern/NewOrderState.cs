using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class NewOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order is being processed.");
            order.State = new ProcessingOrderState();
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Order is canceled.");
            order.State = new CancelledOrderState();
        }
    }
}
