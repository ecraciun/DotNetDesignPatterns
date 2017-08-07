namespace DIAbstractFactory
{
    public class MercedesFactory : ICarFactory
    {
        public IFamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }

        public ISportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }
    }
}