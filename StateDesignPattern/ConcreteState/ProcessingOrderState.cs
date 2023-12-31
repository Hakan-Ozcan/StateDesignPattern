﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Context;
using StateDesignPattern.State;

namespace StateDesignPattern.ConcreteState
{
    public class ProcessingOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order is already being processed.");
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Cannot cancel the order. It is already being processed.");
        }
    }
}
