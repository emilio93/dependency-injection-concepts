using System;
using Unity;

namespace DependencyInjection
{
    public class Driver
    {
        private ICar _car;

        public Driver()
        {
        }

        public void UseCar(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine(
                $"Running {_car.GetType().Name} - {_car.Run()} mile."
            );
        }
    }
}
