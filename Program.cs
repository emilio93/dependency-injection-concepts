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
            container.RegisterType<ICarKey, BMWKey>();
            container.RegisterType<Driver>(new InjectionConstructor(
                container.Resolve<ICar>(), 
                container.Resolve<ICarKey>()
            ));

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
