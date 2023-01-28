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
        public WasteResponseModel GetWaste()
        {
            return new WasteResponseModel
            {
                WasteType = WasteTypes.Other,
                Date = new DateTime(0000, 0, 0)
            };
        }
    }
}
