namespace AbstractFactory
{
    public abstract class CarFactory
    {
        public abstract FamilyCar CreateFamilyCar();
        public abstract SportsCar CreateSportsCar();
    }
}