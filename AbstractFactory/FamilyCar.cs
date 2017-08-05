namespace AbstractFactory
{
    public abstract class FamilyCar
    {
        public abstract int AverageFuelConsumption { get; }
        public abstract int MaximumPeople { get; }

        public abstract void CompareToSport(SportsCar sportsCar);
    }
}