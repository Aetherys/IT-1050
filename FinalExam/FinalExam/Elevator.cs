namespace FinalExam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
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
            return this.GetCurrentWeight() > MaxWeight;
        }
    }
}