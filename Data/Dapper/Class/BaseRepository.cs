using MySql.Data.MySqlClient;
using System.Configuration;

namespace Data.Dapper.Class
{
    public abstract class BaseRepository
    {
        public string connstring = ConfigurationManager.ConnectionStrings["SqlServerConnString"].ConnectionString;

        public MySqlConnection GetMySqlConnection(bool open = true,
            bool convertZeroDatetime = false, bool allowZeroDatetime = false)
        {
            string cs = "Server=dbmy0050.whservidor.com; Port=3306; Database=dm2l_7; Uid=dm2l_7; Pwd=d2ladmin";

            var csb = new MySqlConnectionStringBuilder(cs)
            {
                AllowZeroDateTime = allowZeroDatetime,
                ConvertZeroDateTime = convertZeroDatetime
            };
            var conn = new MySqlConnection(csb.ConnectionString);
            if (open) conn.Open();
            return conn;
        }
    }
}