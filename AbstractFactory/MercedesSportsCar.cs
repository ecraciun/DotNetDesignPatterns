namespace AbstractFactory
{
    public class MercedesSportsCar : SportsCar
    {
        public override bool HasAutomaticTransmission => false;

        public override int MaximumSpeed => 280;

        public override string ToString()
        {
            var transmission = HasAutomaticTransmission ? "automatic" : "manual";
            return $"{nameof(MercedesSportsCar)} - with {transmission} transmission can go up to {MaximumSpeed} km/h";
        }
    }
}