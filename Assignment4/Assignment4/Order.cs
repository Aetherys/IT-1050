using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Order
    {
        public int[] items;

        public void GetOrder()
        {
            int qty = 0;

            for (int i = 0; i < TheaterData.Concessions.Length; i++)
            {
                if (MyTTY.ReadBool("Would you like a " + TheaterData.Concessions[i] + "? "))
                {
                    qty = MyTTY.ReadInt("How many would you like? ");
                    this.items[i] = qty;
                }
                else this.items[i] = 0;
            }
        }
    }
}
