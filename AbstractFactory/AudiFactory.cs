namespace AbstractFactory
{
    public class AudiFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }

        public override SportsCar CreateSportsCar()
        {
            return new AudiSportsCar();
        }
    }
}