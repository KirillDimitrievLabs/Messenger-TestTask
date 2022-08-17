using Messenger.Domain.Interfaces.Repository;
using Messenger.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Infrastructure.Repositories
{
    public interface IMessengerRepository : IRepository<RGDialogsClients>
    {
        Guid FindDialogByClients(IEnumerable<Guid> receivedСlients);
    }
}
