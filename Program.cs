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
                new object[]
                {
                    new Audi(),
                    new AudiKey(),
                    "Steve"
                }
            ));

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
