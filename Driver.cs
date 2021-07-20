using System;
using Unity;

namespace DependencyInjection
{
    public class Driver
    {
        public Driver()
        {
        }

        [Dependency("LuxuryCar")]
        public ICar Car
        {
            get;
            set;
        }

        public void RunCar()
        {
            Console.WriteLine(
                $"Running {Car.GetType().Name} - {Car.Run()} mile."
            );
        }
    }
}
