using MarkMe.API.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TesteTodoList.API.Configurations
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MarkMeContext>(options =>
            {
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
                options.UseSqlServer(configuration.GetConnectionString("MarkMe"));
            });
        }
    }
}
