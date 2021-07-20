using Unity;
using Unity.Injection;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
