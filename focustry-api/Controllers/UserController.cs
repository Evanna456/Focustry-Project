using Dapper;
using focustry_api.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Web;
using BC = BCrypt.Net.BCrypt;

namespace focustry_api.Controllers
{
    [ApiController]
    [Controller]
    public class UserController : Controller
    {
        [Route("/api/register")]
        [HttpPost]
        public IActionResult register(Users user)
        {
            string firstname = HttpUtility.HtmlAttributeEncode(user.firstname)!;
            string lastname = HttpUtility.HtmlAttributeEncode(user.lastname)!;
            string username = HttpUtility.HtmlAttributeEncode(user.username)!;
            string password = HttpUtility.HtmlAttributeEncode(user.password)!;
            string hashed_password = BC.HashPassword(password);



            var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["Default"];
            using (var connection = new MySqlConnection(connectionString))
            {
                var user_v = new { Firstname = firstname, Lastname = lastname, Username = username, Password = hashed_password };
                var sql = "INSERT INTO users (id, role_id, firstname, lastname, username, password, token) VALUES ('', 1,@Firstname, @Lastname, @Username, @Password, '')";
                connection.QueryAsync<Users>(sql, user_v);
            }
            return StatusCode(200);
        }
    }
}
