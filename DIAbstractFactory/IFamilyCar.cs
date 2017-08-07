namespace DIAbstractFactory
{
    public interface IFamilyCar
    {
        int AverageFuelConsumption { get; }
        int MaximumPeople { get; }

        void CompareToSport(ISportsCar sportsCar);
    }
}