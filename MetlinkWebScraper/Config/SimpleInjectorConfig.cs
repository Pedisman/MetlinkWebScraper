using MetlinkWebScraper.Factories;
using MetlinkWebScraper.Interfaces;
using MetlinkWebScraper.Reporters;
using MetlinkWebScraper.ServiceUpdateNodeHelpers;
using SimpleInjector;

namespace MetlinkWebScraper.Config
{
    public class SimpleInjectorConfig
    {
        private static  Container _container;
        public static Container Container => _container;
        public static void RegisterComponents()
        {
            _container = new Container();

            // register the dependencies here
            _container.Register<IServiceUpdateNodeHelper, ServiceUpdateNodeHelper>();
            _container.Register<IServiceUpdateFactory, ServiceUpdateFactory>();
            _container.Register<IConfig, FileConfig>();
            _container.Register<IReporter, ConsoleReporter>();

            // Verify the container
            _container.Verify();
        }
    }
}
