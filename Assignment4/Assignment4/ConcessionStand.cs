using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public static class ConcessionStand
    {
        public static Order Create()
        {
            Order order = new Order();
            order.GetOrder();

            return order;
        }
    }
}
