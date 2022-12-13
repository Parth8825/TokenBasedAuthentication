using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TokenBasedAuthentication.Data.Helpers;

namespace TokenBasedAuthentication.Controllers
{
    [Authorize(Roles = UserRoles.Manager)]
    [ApiController]
    [Route("[controller]")]
    public class ManagementController : ControllerBase
    {
        public ManagementController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to ManagementController");
        }
    }
}
