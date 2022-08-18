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
            bool isEqual = false;
            var groupedDialogsClients = Entities.GroupBy(dialogsClients => dialogsClients.IDRGDialog);

            foreach (var dialog in groupedDialogsClients)
            {
                isEqual = dialog
                    .Select(dialogsClients => dialogsClients.IDClient)
                    .OrderBy(clients => clients)
                    .SequenceEqual(receivedСlients.OrderBy(clients => clients));

                if (isEqual) return dialog.Key;
            }
            return new Guid();
        }

        // CRUD ops...
    }
}
