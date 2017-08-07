namespace AbstractFactory2._0
{
    public interface IFamilyCar
    {
        int AverageFuelConsumption { get; }
        int MaximumPeople { get; }

        void CompareToSport(ISportsCar sportsCar);
    }
}