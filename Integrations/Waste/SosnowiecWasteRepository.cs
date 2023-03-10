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
        public WasteResponseModel GetWaste()
        {
            
            return new WasteResponseModel
            {
                WasteType = WasteTypes.Paper,
                Date = DateTime.Now.Date
            };
        }
    }
}
