using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Integrations.Outages
{
    internal class TauronOutagesRepository : IOutagesRepository
    {
        private static readonly ResourceManager _resourceManager = new("Entities.Resources.WasteTypes1", typeof(Entities.Resources.WasteTypes1).Assembly);
        public string GetOutage(string lang)
        {
            return _resourceManager.GetString("test");
        }
    }
}
