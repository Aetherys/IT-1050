using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevator1IsOverMaxCapacity;
            bool elevator2IsOverMaxCapacity;

            Elevator elevator1 = Elevator.Create(2, 400);
            elevator1.AddOccupant(Passenger.Create("A1", 200), 0);
            elevator1.AddOccupant(Passenger.Create("A1", 220), 1);

            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = Elevator.Create(3, 600);
            elevator2.AddOccupant(Passenger.Create("A1", 200), 0);
            elevator2.AddOccupant(Passenger.Create("A2", 200), 1);
            elevator2.AddOccupant(Passenger.Create("A3", 200), 2);

            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

        }
    }
}
