using iMessengerCoreAPI.Infrastructure.Repositories;
using iMessengerCoreAPI.Interfaces.Repository;
using iMessengerCoreAPI.Interfaces.Services;
using iMessengerCoreAPI.Services;

namespace iMessengerCoreAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IMessengerRepository, InMemoryMessengerRepository>()
                .AddScoped<IMessengerService, MessengerService>();
        }
    }
}
