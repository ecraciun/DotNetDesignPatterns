using System;

namespace AbstractFactory2._0
{
    public class AudiFamilyCar : IFamilyCar
    {
        public int AverageFuelConsumption => 6;

        public int MaximumPeople => 5;

        public void CompareToSport(ISportsCar sportsCar)
        {
            Console.WriteLine($"{this} is slower than {sportsCar}, but it is more practical and badass.");
        }

        public override string ToString()
        {
            return $"{nameof(AudiFamilyCar)} - {AverageFuelConsumption} litres / 100 km, can carry {MaximumPeople} people.";
        }
    }
}