using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keith
{
    public static class MyTTY
    {
        public static void Resize()
        {
            Console.SetWindowSize(Console.WindowWidth * 2, Console.WindowHeight * 2);
        }


        public static void Clear()
        {
            System.Console.Clear(); 
        }


        public static void Show(string text)
        {
            System.Console.Write(text);
        }
        

        public static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        public static string ReadString(string prompt)
        {
            Console.Write(prompt.PadLeft(3) + " ");
            return Console.ReadLine();
        }

        
        public static int ReadInt(string prompt)
        {
            string input = "";
            while (!tryParseInt(input)) input = ReadString(prompt);
            return int.Parse(input);
        }

        
        public static bool ReadBool(string prompt)
        {
            string input = "";
            while (!tryParseBool(input)) input = ReadString(prompt);
            return input.ToLower().StartsWith("y");
        }

        
        private static bool tryParseInt(string text)
        {
            int result;
            return int.TryParse(text, out result);
        }

        
        private static bool tryParseBool(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            if (text.ToLower().StartsWith("y")) return true;
            if (text.ToLower().StartsWith("n")) return true;
            return true;
        }
    }
}