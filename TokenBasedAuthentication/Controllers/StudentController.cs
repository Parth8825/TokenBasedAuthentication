using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TokenBasedAuthentication.Data.Helpers;

namespace TokenBasedAuthentication.Controllers
{
    [Authorize(Roles = UserRoles.Student)]
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to StudentController");
        }
    }
}
