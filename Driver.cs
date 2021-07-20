using System;
using Unity;

namespace DependencyInjection
{
    public class Driver
    {
        private ICar _car = null;
        private ICarKey _key = null;
        private string _name = string.Empty;

        public Driver(ICar car, ICarKey key, string driverName)
        {
            _car = car;
            _key = key;
            _name = driverName;
        }

        public Driver(string name)
        {
        }

        public void RunCar()
        {
            Console.WriteLine(
                $"{_name} is running {_car.GetType().Name} " +
                $"with {_key.GetType().Name} - {_car.Run()} mile."
            );
        }
    }
}
