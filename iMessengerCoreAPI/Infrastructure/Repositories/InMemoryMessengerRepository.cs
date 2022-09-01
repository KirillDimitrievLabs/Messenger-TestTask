using iMessengerCoreAPI.Interfaces.Repository;
using iMessengerCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Infrastructure.Repositories
{
    public class InMemoryMessengerRepository : IMessengerRepository
    {
        public List<RGDialogsClients> Entities { get; }
        public InMemoryMessengerRepository()
        {
            Entities = new RGDialogsClients().Init();
        }

        public Guid FindDialogByClients(IEnumerable<Guid> receivedСlients)
        {
            var foundedDialog = Entities
                .GroupBy(dialogsClients => dialogsClients.IDRGDialog)
                .Where(
                    dialog => dialog
                    .Select(dialogsClients => dialogsClients.IDClient)
                    .OrderBy(clients => clients)
                    .SequenceEqual(receivedСlients.OrderBy(clients => clients))
                    );

            Guid foundedDialogGuid = foundedDialog.First().Key;

            return foundedDialog.Any() ? foundedDialogGuid : new Guid();
        }
        // CRUD ops...
    }
}
