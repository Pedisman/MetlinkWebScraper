using MetlinkWebScraper.Config;
using MetlinkWebScraper.Interfaces;

namespace MetlinkWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInjectorConfig.RegisterComponents();
            MetlinkServiceUpdateFacade facade = new MetlinkServiceUpdateFacade(
                SimpleInjectorConfig.Container.GetInstance<IServiceUpdateNodeHelper>(),
                SimpleInjectorConfig.Container.GetInstance<IServiceUpdateFactory>(),
                SimpleInjectorConfig.Container.GetInstance<IConfig>(),
                SimpleInjectorConfig.Container.GetInstance<IReporter>());
            facade.ProcessServiceUpdates();
        }
    }
}
