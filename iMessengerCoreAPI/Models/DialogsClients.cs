using System;
using System.Collections.Generic;

namespace iMessengerCoreAPI.Models
{

    public class DialogsClients
    {
        public Guid IDUnique { get; set; }
        public Guid IDRGDialog { get; set; }
        public Guid IDClient { get; set; }

        public DateTime? DateEvent { get; set; }
    }
}