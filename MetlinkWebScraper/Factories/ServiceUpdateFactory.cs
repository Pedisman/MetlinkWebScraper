using HtmlAgilityPack;
using MetlinkWebScraper.Interfaces;
using MetlinkWebScraper.Models;
using System.Web;
using System.Linq;

namespace MetlinkWebScraper.Factories
{
    public class ServiceUpdateFactory : IServiceUpdateFactory
    {
        public ServiceUpdate GetServiceUpdate(HtmlNode node)
        {
            return new ServiceUpdate
            {
                Heading = node.SelectSingleNode("div[1]//h5//a").InnerText,
                Body = HttpUtility.HtmlDecode(node.SelectSingleNode("div[1]//p").InnerText),
                ValidFrom = node.SelectSingleNode("div[1]//small").InnerText,
                Services = node.SelectNodes("div[2]//a//span//span")
                .Select(n => n.InnerText)
            };
        }
    }
}
