namespace AbstractFactory2._0
{
    public class AudiFactory : ICarFactory
    {
        public IFamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }

        public ISportsCar CreateSportsCar()
        {
            return new AudiSportsCar();
        }
    }
}