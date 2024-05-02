using Dapper;
using focustry_api.Models;
using MySql.Data.MySqlClient;

namespace focustry_api.Migrations
{
    public class CreateSessionTable
    {
        public void up()
        {
            var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["Default"];
            using (var connection = new MySqlConnection(connectionString))
            {
                var sql = "CREATE TABLE sessions(username VARCHAR(15), token VARCHAR(100), created_at TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP) ENGINE = MEMORY;";
                connection.QueryAsync<Users>(sql);
            }
        }
        public void down()
        {
            var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["Default"];
            using (var connection = new MySqlConnection(connectionString))
            {
                var sql = "DROP TABLE sessions;";
                connection.QueryAsync<Users>(sql);
            }
        }
    }
}
