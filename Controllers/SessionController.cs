using CoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi
{
    [Route("api/[controller]")]
    public class SessionController : Controller
    {
        // GET api/session
        [HttpGet]
        public UserSession Get()
        {
            return new UserSession(HttpContext.Session.Id);
        }
    }
}
