using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory audiFactory = new AudiFactory();
            var audiDriver = new Driver(audiFactory);
            audiDriver.CompareCarTypes();


            CarFactory mercedesFactory = new MercedesFactory();
            var mercedesDriver = new Driver(mercedesFactory);
            mercedesDriver.CompareCarTypes();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}