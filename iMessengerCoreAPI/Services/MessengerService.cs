using Messenger.Domain.Interfaces.Services;
using Messenger.Infrastructure.Repositories;

namespace Messenger.iMessengerCoreAPI.Services
{
    public class MessengerService : IMessengerService
    {
        private readonly IMessengerRepository _repository;

        public MessengerService(IMessengerRepository repository)
        {
            _repository = repository;
        }

        public Guid FindDialogByClients(IEnumerable<Guid> receivedСlients)
        {
            return _repository.FindDialogByClients(receivedСlients);
        }
    }
}