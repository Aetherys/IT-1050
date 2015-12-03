using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace Assignment4
{
    class Plan
    {
        public DateTime ShowTime;
        public string TimesList;
        public int[] Party;
        public string Time;
        public string Movie;
        public int[,] Order;
        public double Bill;

        public void BoxOffice()
        {
            TrmUtil.Clear();
            TrmUtil.Show("\nOk, that's " + this.Party.Length + " for the " + this.Time);
            TrmUtil.Show(" showing of " + this.Movie + "\n");
            Thread.Sleep(2000);
            TrmUtil.Show("\nPress any key to go to the concession stand...");
            System.Console.ReadKey();

        }

        public void ConcessionStand()
        {
            TrmUtil.Clear();
            int count = 0;
            int qty = 0;

            for (int i = 0; i < TheaterData.Concessions.Length; i++)
            {
                if (TrmUtil.ReadBool("Would you like a " + TheaterData.Concessions[i] + "? "))
                {
                    count++;
                    qty = TrmUtil.ReadInt("How many would you like? ");
                    // populate this.Order 
                }
            }
        }

        public void CheckOut()
        {

        }

        public void GetShowInfo()
        {
            TrmUtil.Clear();
            DateTime systime = DateTime.Now;

            string list = "";
            int count = 0;

            foreach (var show in TheaterData.showTimes)
            {
                if (systime < show)
                {
                    count++;
                    list += count.ToString().PadLeft(3);
                    list += show.ToString(") h:mm\n");
                }
            }

            if (list == String.Empty)
            {
                Console.WriteLine("\nSorry, there are no available showtimes today.");
            }
            else
            {
                this.TimesList = list;
                Console.WriteLine("\nHere are today's remaining showtimes: \n" + list);
            }

            int num = TrmUtil.ReadInt("Please select your desired showtime: ");
            this.ShowTime = TheaterData.showTimes[num];
            this.Time = TheaterData.showTimes[num].ToString("h:mm");
            this.Movie = TheaterData.Features[TrmUtil.Roll(7)];
        }


        public void CreateParty()
        {
            System.Console.Clear();
            this.Party = new int[TrmUtil.ReadInt("\nHow many people are going to this showing? ")];

            for (int i = 1; i < this.Party.Length+1; i++)
            {
                System.Console.Clear();
                this.Party[i-1] = TrmUtil.ReadInt("\nAge of person " + i + "? ");
            }

        }

        
        

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
