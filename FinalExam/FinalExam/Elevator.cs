using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public static Elevator Create(int maxOccupants, double maxWeight)
        {
            Elevator elevator = new Elevator();
            elevator.Occupants = new Passenger[maxOccupants];
            elevator.MaxWeight = maxWeight;
            return elevator;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double currentWeight = 0;

            for (int i = 0; i < Occupants.Length; i++)
            {
                currentWeight += this.Occupants[i].GetWeight();
            }

            return currentWeight;
        }


        public bool IsOverMaxCapacity()
        {
            return (this.GetCurrentWeight() > MaxWeight) ? true : false;

        }

    }
}
