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
        public double Bill;
        

        public void BoxOffice()
        {
            MyTTY.Clear();
            MyTTY.Show("\nOk, that's " + this.Party.Length + " for the " + this.Time);
            MyTTY.Show(" showing of " + this.Movie + "\n");
            Thread.Sleep(2000);
            MyTTY.Show("\nPress any key to go to the concession stand...");
            System.Console.ReadKey();

        }


        public void CheckOut()
        {

        }

        public void GetShowInfo()
        {
            MyTTY.Clear();
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

            int num = MyTTY.ReadInt("Please select your desired showtime: ");
            this.ShowTime = TheaterData.showTimes[num];
            this.Time = TheaterData.showTimes[num].ToString("h:mm");
            this.Movie = TheaterData.Features[MyTTY.Roll(7)];
        }


        public void CreateParty()
        {
            System.Console.Clear();
            this.Party = new int[MyTTY.ReadInt("\nHow many people are going to this showing? ")];

            for (int i = 1; i < this.Party.Length+1; i++)
            {
                System.Console.Clear();
                this.Party[i-1] = MyTTY.ReadInt("\nAge of person " + i + "? ");
            }

        }

        
        

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
