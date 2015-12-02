using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Collect
    {
        public static void Greeting()
        {
            System.Console.SetWindowSize(Console.WindowWidth * 2, Console.WindowHeight * 2);
            System.Console.WriteLine("Please supply information regarding three people of your choosing.\nPress any key to begin... ");
            System.Console.ReadKey();
            System.Console.Clear();
        }

        public static bool Lance(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                System.Console.WriteLine("Fuck you, Lance... Answer...");
                return false;
            }
            else return true;
        }

        public static string PromptForString(string s)
        {
            System.Console.Write(s);
            string input = System.Console.ReadLine();

            while (!Lance(input))
            {
                System.Console.Write(s);
                input = System.Console.ReadLine();
            }
            
            return input; 
        }

        public static int PromptForInt(string s)
        {
            System.Console.Write(s);
            string input = System.Console.ReadLine();
            int result;

            while (!Lance(input))
            {
                System.Console.Write(s);
                input = System.Console.ReadLine();
            }

            while (!int.TryParse(input, out result))
            {
                System.Console.Write("Invalid input.\n" + s);
                input = System.Console.ReadLine();
            }
            return result;
        }
        
        public static bool GetSex()
        {
            bool found = false;

            while (found == false)
            {
                System.Console.Write("Sex: ");
                string input = System.Console.ReadLine();

                while (!Lance(input))
                {
                    System.Console.Write("Sex: ");
                    input = System.Console.ReadLine();
                }

                string sex = input.ToLower();

                if (sex.Substring(0,1) == "m")
                {
                    found = true;
                    return true;
                }

                else if (sex.Substring(0,1) == "f")
                {
                    found = true;
                    return false;
                }

                else
                {
                    System.Console.WriteLine("\"" + sex + "\" ain't no gender I ever heard of.");
                    continue;
                }
            }
            return found;
        }

        public static bool isMarried(string pronoun)
        {
            bool found = false;

            while (found == false)
            {
                string prompt = "Is " + pronoun + " married? ";
                System.Console.Write(prompt);
                string input = System.Console.ReadLine();

                while (!Lance(input))
                {
                    System.Console.Write(prompt);
                    input = System.Console.ReadLine();
                }

                string sex = input.ToLower();

                if (sex.Substring(0, 1) == "y")
                {
                    found = true;
                    return true;
                }

                else if (sex.Substring(0, 1) == "n")
                {
                    found = true;
                    return false;
                }

                else
                {
                    System.Console.WriteLine("A simple yes or no will do.");
                    continue;
                }
            }
            return found;
        }
    }
}
