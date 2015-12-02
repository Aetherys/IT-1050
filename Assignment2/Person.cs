using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public bool Sex;
        public bool Married;
        Person Spouse;

        public static int Count = 0;
        public static double AverageAge;

        public static void newEntry()
        {
            System.Console.WriteLine("Thank you. Press any key to enter data for the next person.");
            System.Console.ReadKey();
            System.Console.Clear();
        }

        public string FormatFullName()
        {
            // I shouldn't have to do this gay shit.

            string Name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.FirstName);
            string Surname = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.LastName);
            
            return Name + " " + Surname;
        }

        public string GenderName()
        {
            if (this.Sex) return "Male";
            else return "Female";
        }

        public string GetPronoun()
        {
            if (this.Sex) return "he";
            else return "she";
        }

        public bool isMarried()
        {
            bool found = false;

            while (found == false)
            {
                string ask = ("Is " + this.GetPronoun() + " married? ");
                System.Console.Write(ask);
                string input = System.Console.ReadLine();
                
                while (!Collect.Lance(input))
                {
                    System.Console.Write(ask);
                    input = System.Console.ReadLine();
                }

                if (input.Substring(0,1).ToLower() == "y")
                {
                    this.Married = true;
                    found = true;
                }

                else if (input.Substring(0,1).ToLower() == "n")
                {
                    this.Married = false;
                    found = true;
                }

                else
                {
                    System.Console.WriteLine("We need a yes or a no here, buddy.");
                    continue;
                }
            }

            return this.Married;
        }

        public void CollectData()
        {
            this.FirstName = Collect.PromptForString("First name: ");
            this.LastName = Collect.PromptForString("Last name: ");
            this.Age = Collect.PromptForInt("Age: ");
            this.Sex = Collect.GetSex();

            if (this.isMarried())
            {
                this.Spouse = new Person();
                this.Spouse.FirstName = Collect.PromptForString("Name of spouse: ");
                this.Spouse.Age = Collect.PromptForInt("Age: ");
            }
        }

        public void PrintData()
        {
            string fullName = this.FormatFullName();

            System.Console.WriteLine("Name: ".PadLeft(20, ' ') + fullName);
            System.Console.WriteLine("Age: ".PadLeft(20, ' ') + this.Age);
            System.Console.WriteLine("Gender: ".PadLeft(20, ' ') + this.GenderName());
            System.Console.Write("Spouse: ".PadLeft(20, ' '));
            if (this.Married)
            {
                System.Console.WriteLine(this.Spouse.FirstName);
                System.Console.WriteLine("Age: ".PadLeft(20, ' ') + this.Spouse.Age);
            }
            else System.Console.WriteLine("N/A");

            System.Console.WriteLine("\n");
        }
    }
}
