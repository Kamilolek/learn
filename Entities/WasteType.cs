using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WasteType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
    public static class WasteTypes
    {
        public static WasteType Plastic = new WasteType { Id = 1, Name = "Plastic", Description = "Plastic waste" };
        public static WasteType Paper = new WasteType { Id = 2, Name = "Paper", Description = "Paper waste" };
        public static WasteType Glass = new WasteType { Id = 3, Name = "Glass", Description = "Glass waste" };
        public static WasteType Metal = new WasteType { Id = 4, Name = "Metal", Description = "Metal waste" };
        public static WasteType Organic = new WasteType { Id = 5, Name = "Organic", Description = "Organic waste" };
        public static WasteType Electronic = new WasteType { Id = 6, Name = "Electronic", Description = "Electronic waste" };
        public static WasteType Hazardous = new WasteType { Id = 7, Name = "Hazardous", Description = "Hazardous waste" };
        public static WasteType Other = new WasteType { Id = 8, Name = "Other", Description = "Other waste" };
    }

}
