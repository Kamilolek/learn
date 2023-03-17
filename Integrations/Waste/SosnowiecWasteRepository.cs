using Entities;
using Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.Waste
{
    public class SosnowiecWasteRepository : IWasteRepository
    {
        public WasteResponseModel GetWaste(string lang)
        {
            
            return new WasteResponseModel
            {
                WasteType = WasteTypes.GetWasteTypeObject("en"),
                Date = DateTime.Now.Date
            };
        }
    }
}
