using System;

namespace AbstractFactory2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory audiFactory = new AudiFactory();
            var audiDriver = new Driver(audiFactory);
            audiDriver.CompareCarTypes();


            ICarFactory mercedesFactory = new MercedesFactory();
            var mercedesDriver = new Driver(mercedesFactory);
            mercedesDriver.CompareCarTypes();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}