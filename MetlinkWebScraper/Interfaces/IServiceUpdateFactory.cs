using HtmlAgilityPack;
using MetlinkWebScraper.Models;

namespace MetlinkWebScraper.Interfaces
{
    /// <summary>
    /// Interface allows us to extend functionality to cater for formatting changes in the metlink web site
    /// </summary>
    public interface IServiceUpdateFactory
    {
        ServiceUpdate GetServiceUpdate(HtmlNode node);
    }
}
