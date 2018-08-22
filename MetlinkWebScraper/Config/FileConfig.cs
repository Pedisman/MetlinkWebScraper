using System;
using MetlinkWebScraper.Interfaces;
using System.Configuration;

namespace MetlinkWebScraper.Config
{
    public class FileConfig : IConfig
    {
        private string _serviceCode = ConfigurationManager.AppSettings["ServiceCode"];
        public string ServiceCode => _serviceCode;
    }
}
