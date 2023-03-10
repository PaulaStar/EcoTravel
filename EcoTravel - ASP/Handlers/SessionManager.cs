using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Handlers
{
    public class SessionManager
    {
        private readonly ISession _session; public SessionManager(IHttpContextAccessor accessor)
        {
            _session = accessor.HttpContext.Session;
        }
        public CurrentClient CurrentClient
        {
            get
            {
                string data = _session.GetString(nameof(CurrentClient));
                if (data is null) return null;
                return JsonSerializer.Deserialize<CurrentClient>(data);
            }
            set
            {
                if (value is null) _session.Remove(nameof(CurrentClient));
                else _session.SetString(
                nameof(CurrentClient),
                JsonSerializer.Serialize(value)
                );
                }
            }
    }
    
}
