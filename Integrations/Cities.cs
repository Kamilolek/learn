using Entities;
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
        public string? Name { get; set; }
        public string? Url { get; set; }
        public Services[] AvailableServices { get; set; } = Array.Empty<Services>();
        public IWasteRepository? WasteRepository { get; set; }
    }
    public class Cities
    {
        private readonly IWasteRepository _wasteRepository;
        public Cities(IWasteRepository wasteRepository)
        {
            _wasteRepository = wasteRepository;
        }
        private readonly static City Sosnowiec = new()
        {
            Name = "Sosnowiec",
            Url = "https://sosnowiec.pl",
            AvailableServices = new Services[] { Services.Waste, Services.Outages, Services.News },
            WasteRepository = new SosnowiecWasteRepository()
        };
        private static readonly City Katowice = new()
        {
            Name = "Katowice",
            Url = "https://katowice.pl",
            WasteRepository = new KatowiceWasteRepository()
        };
    
        public static City GetCity(string name)
        {
            switch (name.ToLower())
            {
                case "sosnowiec":
                    return Sosnowiec;
                case "katowice":
                    return Katowice;
                default:
                    throw new Exception("City not found");
            }
        }
    }
}
