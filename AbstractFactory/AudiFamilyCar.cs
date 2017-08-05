using System;

namespace AbstractFactory
{
    public class AudiFamilyCar : FamilyCar
    {
        public override int AverageFuelConsumption => 6;

        public override int MaximumPeople => 5;

        public override void CompareToSport(SportsCar sportsCar)
        {
            Console.WriteLine($"{this} is slower than {sportsCar}, but it is more practical and badass.");
        }

        public override string ToString()
        {
            return $"{nameof(AudiFamilyCar)} - {AverageFuelConsumption} litres / 100 km, can carry {MaximumPeople} people.";
        }
    }
}