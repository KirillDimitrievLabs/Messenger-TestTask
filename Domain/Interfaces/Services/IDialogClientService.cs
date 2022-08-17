using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Domain.Interfaces.Services
{
    public interface IMessengerService
    {
        Guid FindDialogByClients(IEnumerable<Guid> receivedСlients);
    }
}
