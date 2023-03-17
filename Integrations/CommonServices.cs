using Integrations.Outages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Integrations
{
    internal class CommonServices
    {
        public static readonly IOutagesRepository Tauron = new TauronOutagesRepository();
        public static IOutagesRepository GetOutagesRepository(string key)
        {
            return key.ToLower() switch
            {
                "tauron" => Tauron,
                _ => throw new Exception("Service not found"),
            };
        }
    }
}
