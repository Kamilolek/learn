using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.Outages
{
    public interface IOutagesRepository
    {
        string GetOutage(string lang);
    }
}
