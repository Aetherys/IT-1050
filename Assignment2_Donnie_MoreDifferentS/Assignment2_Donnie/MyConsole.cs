using System;

namespace Assignment2_Donnie
{
    public static class MyConsole
    {
        public static string ReadString(string prompt)
        {
            Console.Write(prompt.PadRight(33) + " : ");
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