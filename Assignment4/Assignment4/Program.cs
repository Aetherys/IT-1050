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
            TrmUtil.Resize();
            Plan plan = new Plan();
            TrmUtil.ReadBool("Would you like to go to the movies? ");
            plan.GetShowInfo();
            plan.CreateParty();
            plan.BoxOffice();
            plan.ConcessionStand();

            

            Console.ReadKey();

        }

    /////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////

    }
}
