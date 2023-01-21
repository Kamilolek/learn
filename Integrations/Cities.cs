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
        public string Name { get; set; }
        public string Url { get; set; }
        public IWasteRepository WasteRepository { get; set; }
    }
    public class Cities
    {
        public static City Sosnowiec = new City
        {
            Name = "Sosnowiec",
            Url = "https://sosnowiec.pl",
            WasteRepository = new SosnowiecWasteRepository()
        };
        public static City Katowice = new City
        {
            Name = "Katowice",
            Url = "https://katowice.pl",
            WasteRepository = new KatowiceWasteRepository()
        };
    }
}
