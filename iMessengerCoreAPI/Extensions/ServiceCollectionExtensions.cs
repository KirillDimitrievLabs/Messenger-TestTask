using Messenger.Domain.Interfaces.Services;
using Messenger.iMessengerCoreAPI.Services;
using Messenger.Infrastructure.Repositories;

namespace Messenger.iMessengerCoreAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IMessengerRepository, MessengerRepository>()
                .AddScoped<IMessengerService, MessengerService>();
        }
    }
}
