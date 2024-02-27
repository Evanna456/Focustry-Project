using Microsoft.AspNetCore.Mvc;

namespace focustry_api.Controllers
{
    [ApiController]
    [Controller]
    public class UserController : Controller
    {
        [Route("/api/register")]
        [HttpGet]
        public IActionResult register()
        {
            string firstname = Convert.ToString(Request.Query["firstname"]);
            string lastname = Convert.ToString(Request.Query["lastname"]);
            string username = Convert.ToString(Request.Query["username"]);
            string email = Convert.ToString(Request.Query["email"]);
            return Content(firstname);
        }
    }
}
