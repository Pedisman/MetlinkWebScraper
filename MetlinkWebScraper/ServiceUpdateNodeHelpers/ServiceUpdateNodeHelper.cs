using System.Collections.Generic;
using HtmlAgilityPack;
using MetlinkWebScraper.Interfaces;

namespace MetlinkWebScraper.ServiceUpdateNodeHelpers
{
    public class ServiceUpdateNodeHelper : IServiceUpdateNodeHelper
    {
        public IEnumerable<HtmlNode> GetMetlinkServiceUpdateNodes()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.metlink.org.nz/service-updates");
            return doc.DocumentNode
                .SelectNodes("//div[contains(@class, 'row serviceUpdateItem')]");
        }
    }
}
