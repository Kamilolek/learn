using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace Entities
{
    public enum WasteType
    {
        Plastic,
        Paper,
        Glass,
        Metal,
        Organic,
        Other

    }
    public class WasteTypeObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
    public static class WasteTypes
    {
        private static readonly ResourceManager _resourceManager = new ResourceManager("Entities.Resources.WasteTypes1", Assembly.GetExecutingAssembly());
        public static WasteTypeObject GetWasteTypeObject(string language)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture(language);
            return new WasteTypeObject {
                Id = 1,
                Name = _resourceManager.GetString("test", culture) ?? "",
                Description = language
            };
        }
    }
}
