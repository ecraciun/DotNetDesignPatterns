using System;

namespace DIAbstractFactory
{
    public class MercedesFamilyCar : IFamilyCar
    {
        public int AverageFuelConsumption => 9;

        public int MaximumPeople => 8;

        public void CompareToSport(ISportsCar sportsCar)
        {
            Console.WriteLine($"{this} is slower than {sportsCar}, but it is more practical and classy.");
        }

        public override string ToString()
        {
            return $"{nameof(MercedesFamilyCar)} - {AverageFuelConsumption} litres / 100 km, can carry {MaximumPeople} people.";
        }
    }
}