using focustry_api.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Web;
namespace focustry_api.Controllers

{
    [ApiController]
    [Controller]
    public class UserController : Controller
    {
        [Route("/api/register")]
        [HttpGet]
        public void register()
        {
            string firstname = HttpUtility.HtmlAttributeEncode(Convert.ToString(Request.Query["firstname"]));
            string lastname = HttpUtility.HtmlAttributeEncode(Convert.ToString(Request.Query["lastname"]));
            string username = HttpUtility.HtmlAttributeEncode(Convert.ToString(Request.Query["username"]));
            string email = HttpUtility.HtmlAttributeEncode(Convert.ToString(Request.Query["email"]));

            List<Users> customers = new List<Users>();
            var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["Default"];


            using (var connection = new MySqlConnection(connectionString))
            {

            }
        }
    }
}
