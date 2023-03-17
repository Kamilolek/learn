using Entities;
using Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.Waste
{
    public class WasteRepository : IWasteRepository
    {
        public WasteResponseModel GetWaste(string lang)
        {
            return new WasteResponseModel
            {
                WasteType = WasteTypes.GetWasteTypeObject(lang),
                Date = new DateTime(0000, 0, 0)
            };
        }

    }
}
