using iMessengerCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Interfaces.Repository
{
    public interface IMessengerRepository : IRepository<RGDialogsClients>
    {
        Guid FindDialogByClients(IEnumerable<Guid> receivedСlients);
    }
}
