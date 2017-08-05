using System;

namespace AbstractFactory
{
    public class MercedesFamilyCar : FamilyCar
    {
        public override int AverageFuelConsumption => 9;

        public override int MaximumPeople => 8;

        public override void CompareToSport(SportsCar sportsCar)
        {
            Console.WriteLine($"{this} is slower than {sportsCar}, but it is more practical and classy.");
        }

        public override string ToString()
        {
            return $"{nameof(MercedesFamilyCar)} - {AverageFuelConsumption} litres / 100 km, can carry {MaximumPeople} people.";
        }
    }
}