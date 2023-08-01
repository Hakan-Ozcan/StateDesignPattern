using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Context;
using StateDesignPattern.State;

namespace StateDesignPattern.ConcreteState
{
    public class NewOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order is being processed."); //sipariş hazırlanıyor
            order.State = new ProcessingOrderState();
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Order is canceled.");//sipariş iptal edildi
            order.State = new CancelledOrderState();
        }
    }
}
