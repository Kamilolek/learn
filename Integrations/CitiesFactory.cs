using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrations.Outages;
using Integrations.Waste;

namespace Integrations
{
    public class CitiesFactory
    {
        public static IWasteRepository GetWasteRepository(string city)
        {
            City _city = Cities.GetCity(city);
            return _city.WasteRepository;
        }
        public static IOutagesRepository GetOutagesRepository(string city)
        {
            City _city = Cities.GetCity(city);
            if(_city.CommonServices.ContainsKey("outages"))
            {
                return CommonServices.GetOutagesRepository(_city.CommonServices["outages"]);
            }
            return _city.OutageRepository;
        }
    }
}
