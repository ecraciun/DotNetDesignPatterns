namespace AbstractFactory
{
    public class Driver
    {
        private readonly SportsCar _sportsCar;
        private readonly FamilyCar _familyCar;

        public Driver(CarFactory carFactory)
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