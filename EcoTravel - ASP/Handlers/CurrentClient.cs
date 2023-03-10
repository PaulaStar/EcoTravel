using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Handlers
{
    public class CurrentClient
    {
        public int id_Client { get; set; }
        public string email { get; set; }
        public DateTime derniereConnection { get; set; }
    }
}
