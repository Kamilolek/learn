using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Response
{
    public record WasteResponseModel
    {
        public WasteType WasteType { get; set; }
        public DateTime Date { get; set; }
        
    }
}
