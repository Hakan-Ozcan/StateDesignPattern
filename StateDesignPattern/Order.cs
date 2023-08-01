using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class Order
    {
        public IOrderState State { get; set; }

        public Order()
        {
            State = new NewOrderState();
        }

        public void ProcessOrder()
        {
            State.ProcessOrder(this);
        }

        public void CancelOrder()
        {
            State.CancelOrder(this);
        }
    }
}
