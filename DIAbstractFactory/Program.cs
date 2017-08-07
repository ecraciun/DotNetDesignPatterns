using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ICarFactory, MercedesFactory>()
                .AddTransient<Driver>()
                .BuildServiceProvider();

            var driver = serviceProvider.GetService<Driver>();
            driver.CompareCarTypes();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}