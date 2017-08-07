namespace AbstractFactory2._0
{
    public class AudiSportsCar : ISportsCar
    {
        public bool HasAutomaticTransmission => true;

        public int MaximumSpeed => 320;

        public override string ToString()
        {
            var transmission = HasAutomaticTransmission ? "automatic" : "manual";
            return $"{nameof(AudiSportsCar)} - with {transmission} transmission can go up to {MaximumSpeed} km/h";
        }
    }
}