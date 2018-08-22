using HtmlAgilityPack;
using System.Collections.Generic;

namespace MetlinkWebScraper.Interfaces
{
    /// <summary>
    /// Interface allows us to extend functionality to cater for formatting changes in the metlink web site
    /// </summary>
    public interface IServiceUpdateNodeHelper
    {
        IEnumerable<HtmlNode> GetMetlinkServiceUpdateNodes();
    }
}
