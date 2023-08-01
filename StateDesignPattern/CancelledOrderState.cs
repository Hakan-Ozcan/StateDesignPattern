using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class CancelledOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Cannot process the order. It is cancelled.");
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Order is already cancelled.");
        }
    }
}
