using MetlinkWebScraper.Interfaces;

namespace MetlinkWebScraper
{
    public class MetlinkServiceUpdateFacade
    {
        private readonly IConfig _config;
        private readonly IReporter _reporter;
        private readonly MetlinkServiceUpdateScraper _serviceUpdateScraper;
        public MetlinkServiceUpdateFacade(IServiceUpdateNodeHelper serviceUpdateNodeHelper,
            IServiceUpdateFactory serviceUpdateFactory,
            IConfig config, 
            IReporter reporter)
        {
            _config = config;
            _reporter = reporter;
            _serviceUpdateScraper = new MetlinkServiceUpdateScraper(serviceUpdateNodeHelper,
                serviceUpdateFactory);
        }
        public void ProcessServiceUpdates()
        {
            _reporter.Report(_serviceUpdateScraper.GetUpdates(_config.ServiceCode));
        }
    }
}
