using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CityManager.DAL.DependencyInjection
{
    public static class DependecyInjection
    {
        public static void AddDataAccessLayer(this IServiceCollection service)
        {
            InitRepositories(service);
        }

        public static string? GetConnection(this IConfiguration configuration) => configuration.GetConnectionString(name: "CitiesDB");

        private static void InitRepositories(this IServiceCollection services)
        {

        }
    }
}
