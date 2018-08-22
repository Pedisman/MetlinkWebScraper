using System.Collections.Generic;

namespace MetlinkWebScraper.Models
{
    public class ServiceUpdate
    {
        /// <summary>
        /// Service update heading
        /// </summary>
        public string Heading { get; set; }
        /// <summary>
        /// Service update body
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Date from which service update applies
        /// </summary>
        public string ValidFrom { get; set; }
        /// <summary>
        /// List of services which the service update applies to e.g. WRL, HVL etc
        /// </summary>
        public IEnumerable<string> Services { get; set; }

        public override string ToString()
        {
            return $"Heading: {Heading}\nBody: {Body}\nValidFrom: {ValidFrom}";
        }
    }
}
