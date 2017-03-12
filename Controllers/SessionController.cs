using CoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi
{
    [Route("api/[controller]")]
    public class SessionController : Controller
    {
        private AppTenant _tenant;

        public SessionController(AppTenant tenant)
        {
            _tenant = tenant;
        }

        // GET api/session
        [HttpGet]
        public UserSession Get()
        {
            return new UserSession(HttpContext.Session.Id, _tenant);
        }
    }
}
