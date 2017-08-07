namespace DIAbstractFactory
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