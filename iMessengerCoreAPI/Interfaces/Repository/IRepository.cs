using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> Entities { get; }

        // Base CRUD methods...
    }
}
