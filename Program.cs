﻿namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new BMW());

            driver.RunCar();
        }
    }
}
