using MetlinkWebScraper.Interfaces;
using MetlinkWebScraper.Models;
using System.Collections.Generic;
using System.Linq;

namespace MetlinkWebScraper
{
    public class MetlinkServiceUpdateScraper
    {
        private readonly IServiceUpdateNodeHelper _serviceUpdateNodeHelper;
        private readonly IServiceUpdateFactory _serviceUpdateFactory;
        public MetlinkServiceUpdateScraper(IServiceUpdateNodeHelper serviceUpdateNodeHelper,
            IServiceUpdateFactory serviceUpdateFactory)
        {
            _serviceUpdateNodeHelper = serviceUpdateNodeHelper;
            _serviceUpdateFactory = serviceUpdateFactory;
        }

        public IEnumerable<ServiceUpdate> GetUpdates(string serviceCode)
        {
            return _serviceUpdateNodeHelper.GetMetlinkServiceUpdateNodes()
                .Select(n => _serviceUpdateFactory.GetServiceUpdate(n))
                .Where(n => n.Services.Any(s => s == serviceCode));
        }
    }
}
