using FluentValidation.AspNetCore;
using MarkMe.API.Domain;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TesteTodoList.API.Filters;

namespace TesteTodoList.API.Configurations
{
    public static class ControllerSetup
    {
        public static void AddControllerSetup(this IServiceCollection services)
        {
            services
                .AddMvc(options =>
                {
                    options.Filters.Add(typeof(ModelValidationFilter));
                })
                .AddFluentValidation(options =>
                {
                    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });
        }
    }
}
