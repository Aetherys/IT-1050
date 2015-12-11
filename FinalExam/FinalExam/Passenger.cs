using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExam
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public static Passenger Create(string name, double weight)
        {
            Passenger passenger = new Passenger();
            passenger.Name = name;
            passenger.Weight = weight;
            return passenger;
        }


        public string GetName()
        {
            return this.Name;
        }


        public double GetWeight()
        {
            return this.Weight;
        }

    }
}
