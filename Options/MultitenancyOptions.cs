using System.Collections.ObjectModel;
using CoreWebApi.Models;

namespace CoreWebApi.Options
{
    public class MultitenancyOptions
    {
        public Collection<AppTenant> Tenants { get; set; }
    }
}
