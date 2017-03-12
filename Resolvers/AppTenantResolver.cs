using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Models;
using CoreWebApi.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using SaasKit.Multitenancy;

namespace CoreWebApi.Resolvers
{
    public class AppTenantResolver : ITenantResolver<AppTenant>
    {
        private readonly IEnumerable<AppTenant> tenants;

        public AppTenantResolver(IOptions<MultitenancyOptions> options)
        {
            this.tenants = options.Value.Tenants;
        }

        public Task<TenantContext<AppTenant>> ResolveAsync(HttpContext context)
        {
            TenantContext<AppTenant> tenantContext = null;

            var tenant = tenants.FirstOrDefault(t =>
                t.Hostnames.Any(h => h.Equals(context.Request.Host.Value.ToLower())));

            if (tenant != null)
            {
                tenantContext = new TenantContext<AppTenant>(tenant);
            }

            return Task.FromResult(tenantContext);
        }
    }
}
