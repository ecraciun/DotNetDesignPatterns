namespace AbstractFactory2._0
{
    public interface ICarFactory
    {
        IFamilyCar CreateFamilyCar();
        ISportsCar CreateSportsCar();
    }
}