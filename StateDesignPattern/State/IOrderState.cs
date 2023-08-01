using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    public interface IOrderState
    {
        void ProcessOrder(Order order);
        void CancelOrder(Order order);
    }
}
