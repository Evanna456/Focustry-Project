using Dapper;
using focustry_api.Models;
using MySql.Data.MySqlClient;

namespace focustry_api.Migrations
{
    public class CreateUserTable
    {
        public void up()
        {
            var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["Default"];
            using (var connection = new MySqlConnection(connectionString))
            {
                var sql = "CREATE TABLE users(id BIGINT UNSIGNED AUTO_INCREMENT, role_id INT UNSIGNED, firstname VARCHAR(100), lastname VARCHAR(100), username VARCHAR(15), password VARCHAR(255), remember_token VARCHAR(20), remember_token_expiry TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP, primary key(id));";
                connection.QueryAsync<Users>(sql);
            }
        }
        public void down()
        {
            var connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["Default"];
            using (var connection = new MySqlConnection(connectionString))
            {
                var sql = "DROP TABLE users;";
                connection.QueryAsync<Users>(sql);
            }
        }
    }
}
