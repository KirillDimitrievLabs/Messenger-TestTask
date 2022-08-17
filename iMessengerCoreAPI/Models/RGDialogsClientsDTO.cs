using System;
using System.Collections.Generic;

namespace Messenger.iMessengerCoreAPI.Models
{

    public class RGDialogsClientsDTO
    {
        public Guid IDUnique { get; set; }
        public Guid IDRGDialog { get; set; }
        public Guid IDClient { get; set; }

        public DateTime? DateEvent { get; set; }
    }
}