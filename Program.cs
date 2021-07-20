using Unity;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICarKey, BMWKey>();

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
