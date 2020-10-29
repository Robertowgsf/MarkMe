using MarkMe.API.Infrastructure.Data.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace MarkMe.API.Infrastructure.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<MarkMeContext>();
        }
    }
}
