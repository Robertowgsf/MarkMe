using MarkMe.API;
using MarkMe.API.Infrastructure.Data.Contexts;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Net.Http;

namespace MarkMe.IntegrationTests.Core
{
    public class IntegrationTest
    {
        protected readonly HttpClient TestServer;

        public IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<MarkMeContext>));

                        if (descriptor != null)
                        {
                            services.Remove(descriptor);
                        }

                        services.AddDbContext<MarkMeContext>(options => options.UseInMemoryDatabase("MarkMeIntegrationTests"));
                    });
                });

            TestServer = appFactory.CreateClient();
        }
    }
}
