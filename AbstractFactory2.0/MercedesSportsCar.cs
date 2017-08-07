namespace AbstractFactory2._0
{
    public class MercedesSportsCar : ISportsCar
    {
        public bool HasAutomaticTransmission => false;

        public int MaximumSpeed => 280;

        public override string ToString()
        {
            var transmission = HasAutomaticTransmission ? "automatic" : "manual";
            return $"{nameof(MercedesSportsCar)} - with {transmission} transmission can go up to {MaximumSpeed} km/h";
        }
    }
}