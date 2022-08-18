using iMessengerCoreAPI.Interfaces.Repository;
using iMessengerCoreAPI.Interfaces.Services;

namespace iMessengerCoreAPI.Services
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

        // CRUD ops...
        // and other logic
    }
}