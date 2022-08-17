using Messenger.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.iMessengerCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DialogController : ControllerBase
    {
        private readonly IMessengerService _dialogClientService;
        private readonly ILogger<DialogController> _logger;

        public DialogController(ILogger<DialogController> logger, IMessengerService dialogClientService)
        {
            _logger = logger;
            _dialogClientService = dialogClientService;
        }
        /// <summary>
        /// Finds Dialog's guid by clients guids
        /// </summary>
        /// <returns> Dialog's guid </returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /Dialog
        ///     {
        ///         "4b6a6b9a-2303-402a-9970-6e71f4a47151",
        ///         "c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820",
        ///         "7de3299b-2796-4982-a85b-2d6d1326396e"
        ///     }
        ///     
        ///</remarks>
        /// <response code="201"> Dialog's guid </response>
        [HttpPost()]
        public Guid Get([FromBody] IEnumerable<Guid> clients)
        {
            Guid dialogGuid = _dialogClientService.FindDialogByClients(clients);
            
            return dialogGuid;
        }
    }
}