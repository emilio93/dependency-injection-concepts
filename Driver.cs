using System;

namespace DependencyInjection
{
    public class Driver
    {
        private ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine(
                $"Running { _car.GetType().Name} - {_car.Run()} mile"
            );
        }
    }
}
