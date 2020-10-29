using MarkMe.API.Infrastructure.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace TesteTodoList.API.Configurations
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
