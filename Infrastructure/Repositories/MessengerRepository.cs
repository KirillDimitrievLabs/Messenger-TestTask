using Messenger.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Infrastructure.Repositories
{
    public class MessengerRepository : IMessengerRepository
    {
        public List<RGDialogsClients> Entities { get; }
        public MessengerRepository()
        {
            Entities = new RGDialogsClients().Init();
        }

        public Guid FindDialogByClients(IEnumerable<Guid> receivedСlients)
        {
            var groupedDialogsClients = Entities.GroupBy(dialogsClients => dialogsClients.IDRGDialog);

            foreach (var dialog in groupedDialogsClients)
            {
                bool isEqual = dialog
                    .Select(dialogsClients => dialogsClients.IDClient)
                    .OrderBy(clients => clients)
                    .SequenceEqual(receivedСlients.OrderBy(clients => clients));

                return isEqual ? dialog.Key : new Guid();
            }
            return new Guid();
        }
    }
}
