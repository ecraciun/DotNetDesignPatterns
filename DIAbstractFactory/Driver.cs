namespace DIAbstractFactory
{
    public class Driver
    {
        private readonly ISportsCar _sportsCar;
        private readonly IFamilyCar _familyCar;

        public Driver(ICarFactory carFactory)
        {
            _sportsCar = carFactory.CreateSportsCar();
            _familyCar = carFactory.CreateFamilyCar();
        }

        public void CompareCarTypes()
        {
            _familyCar.CompareToSport(_sportsCar);
        }
    }
}