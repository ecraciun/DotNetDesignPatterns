namespace AbstractFactory
{
    public abstract class SportsCar
    {
        public abstract bool HasAutomaticTransmission { get; }
        public abstract int MaximumSpeed { get; }
    }
}