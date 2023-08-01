﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IOrderState
    {
        void ProcessOrder(Order order);
        void CancelOrder(Order order);
    }
}