using Entities;
using Integrations.Outages;
using Integrations.Waste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations
{
    public class City
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public Services[] AvailableServices { get; set; } = Array.Empty<Services>();
        public IWasteRepository? WasteRepository { get; set; }
        public IOutagesRepository? OutageRepository { get; set; }
        public Dictionary<string, string> CommonServices { get; set; } = new();
    }
    public class Cities
    {
        private readonly static City Sosnowiec = new()
        {
            Name = "Sosnowiec",
            Url = "https://sosnowiec.pl",
            AvailableServices = new Services[] { Services.Waste, Services.Outages, Services.News },
            WasteRepository = new SosnowiecWasteRepository(),
            CommonServices = new Dictionary<string, string>()
            {
                { "outages", "tauron" }
            }
        };
        private static readonly City Katowice = new()
        {
            Name = "Katowice",
            Url = "https://katowice.pl",
            WasteRepository = new KatowiceWasteRepository(),
            CommonServices = new Dictionary<string, string>()
            {
                { "outages", "tauron" }
            }
        };
    
        public static City GetCity(string name)
        {
            return name.ToLower() switch
            {
                "sosnowiec" => Sosnowiec,
                "katowice" => Katowice,
                _ => throw new Exception("City not found"),
            };
        }
    }
}
