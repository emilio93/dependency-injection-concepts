using System;

namespace DependencyInjection
{
    public class Driver
    {
        private ICar _car = null;
        private ICarKey _key = null;

        public Driver(ICar car, ICarKey key)
        {
            _car = car;
            _key = key;
        }

        public void RunCar()
        {
            Console.WriteLine(
                $"Running {_car.GetType().Name} " +
                $"with {_key.GetType().Name} - {_car.Run()} mile "
            );
        }
    }
}
