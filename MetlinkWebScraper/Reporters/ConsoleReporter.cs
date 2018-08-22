using System;
using System.Collections.Generic;
using MetlinkWebScraper.Interfaces;
using MetlinkWebScraper.Models;
using System.Linq;

namespace MetlinkWebScraper.Reporters
{
    public class ConsoleReporter : IReporter
    {
        public void Report(IEnumerable<ServiceUpdate> serviceUpdates)
        {
            serviceUpdates.ToList().ForEach(s => Console.WriteLine(s.ToString() + "\n"));
        }
    }
}
