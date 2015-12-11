using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTTY.Resize();
            Plan plan = new Plan();
            //MyTTY.ReadBool("Would you like to go to the movies? ");
            //plan.GetShowInfo();
            //plan.CreateParty();
            //plan.BoxOffice();
            Order order = ConcessionStand.Create();

            

            Console.ReadKey();

        }

    /////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////

    }
}
