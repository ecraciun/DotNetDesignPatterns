namespace AbstractFactory
{
    public class MercedesFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }

        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }
    }
}