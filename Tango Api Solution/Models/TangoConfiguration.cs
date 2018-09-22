using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TangoApiSolution.Models
{
    public class TangoConfiguration
    {
        public static TangoCard.Raas.RaasClient Configuration()
        {
            TangoCard.Raas.Configuration.PlatformName = "QAPlatform2";
            TangoCard.Raas.Configuration.PlatformKey = "apYPfT6HNONpDRUj3CLGWYt7gvIHONpDRUYPfT6Hj";
            TangoCard.Raas.RaasClient client = new TangoCard.Raas.RaasClient();
            return client;
        }
    }
}
