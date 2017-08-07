namespace DIAbstractFactory
{
    public interface ICarFactory
    {
        IFamilyCar CreateFamilyCar();
        ISportsCar CreateSportsCar();
    }
}