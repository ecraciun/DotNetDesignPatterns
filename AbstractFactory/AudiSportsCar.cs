namespace AbstractFactory
{
    public class AudiSportsCar : SportsCar
    {
        public override bool HasAutomaticTransmission => true;

        public override int MaximumSpeed => 320;

        public override string ToString()
        {
            var transmission = HasAutomaticTransmission ? "automatic" : "manual";
            return $"{nameof(AudiSportsCar)} - with {transmission} transmission can go up to {MaximumSpeed} km/h";
        }
    }
}