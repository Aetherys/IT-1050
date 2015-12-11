using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public static class TheaterData
    {
        public const int TicketPrice = 14;
        public const int ThreeD = 4;
        public const int Imax = 6;
        public const int ImaxThreeD = 7;
        public const int StudentDisc = -1;
        public const int ChildDisc = -3;
        public const int MilDisc = -2;
        public const int ComboDisc = -2;

        public const double Candy = 3.50;
        public const double SmSoda = 3.50;
        public const double LgSoda = 5.99;
        public const double Hotdog = 3.99;
        public const double Popcorn = 4.50;

        public static DateTime[] showTimes =
        {
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 45, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 35, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 55, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 05, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 50, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 25, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 50, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 20, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 45, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 15, 0)
        };

        public static string[] Concessions = { "box of candy", "small soda", "large soda", "hot dog", "bucket of popcorn" };

        public static string[] Features =
        {   "that movie where Tom Cruise pretends he isn't old.",
            "a movie with enough CGI to distract you from its lack of substance.",
            "Robert Downey Jr being Robert Downey Jr. Again.",
            "Bridget Jones' Diary. Wait a minute...\nWhat's this doing in there? Faggot shit!",
            "The Bourne Redundancy starring Matt Damon.",
            "something you're only watching for that tight 14-year-old female lead.",
            "BATTLEFIELD EARTH!\nYou know, because leverage."
        };      
        
    }
}