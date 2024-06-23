using Microsoft.Extensions.Configuration;

namespace Domain.Middlewares
{
    public static class AppSettings
    {
        public static string? connectionString { get; set; }
        public static void LoadSettings(IConfiguration config)
        {
            connectionString = config["Dapper:ConnectionString"];
        }   
    }
}
