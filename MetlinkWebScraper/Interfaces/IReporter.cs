using MetlinkWebScraper.Models;
using System.Collections.Generic;

namespace MetlinkWebScraper.Interfaces
{
    /// <summary>
    /// Interface to abstract reporting medium (console, logfile, text, email, webhook etc)
    /// </summary>
    public interface IReporter
    {
        void Report(IEnumerable<ServiceUpdate> serviceUpdates);
    }
}
