using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Collect.Greeting();

            Person entry1 = new Person();
            Person.Count++;
            entry1.CollectData();

            Person.newEntry();

            Person entry2 = new Person();
            Person.Count++;
            entry2.CollectData();

            Person.newEntry();

            Person entry3 = new Person();
            Person.Count++;
            entry3.CollectData();

            System.Console.WriteLine("Thank you. Press any key to display results...");
            System.Console.ReadKey();
            System.Console.Clear();

            System.Console.WriteLine("Data for Person #1:");
            entry1.PrintData();
            System.Console.WriteLine("Data for Person #2:");
            entry2.PrintData();
            System.Console.WriteLine("Data for Person #3:");
            entry3.PrintData();

            System.Console.WriteLine("Donnie asked for average age, but I have a question about it and he didn't call me because he was watching a movie.\n");

            System.Console.WriteLine("Press any key to exit... ");
            System.Console.ReadKey();

        }
    }
}
