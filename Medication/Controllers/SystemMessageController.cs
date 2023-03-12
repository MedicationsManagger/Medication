using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO;
using AutoMapper;
using Services;
using System.Xml.Linq;

    
namespace Medication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemMessageController : ControllerBase
    {
        private readonly ISystemMessageService _SystemMessageService;
        private readonly IMapper _mapper;

        public SystemMessageController(ISystemMessageService SystemMessageService, IMapper mapper)
        {
            _SystemMessageService = SystemMessageService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<SystemMessage>>> Get([FromQuery] int userId)
        {
            IEnumerable<SystemMessage>? systemMessages = await _SystemMessageService.getSystemMessages(userId);

            if (systemMessages == null)
            {
                return NoContent();
            }

            return Ok(systemMessages);
 
        }



        [HttpPost]
        public async Task<ActionResult<SystemMessageDTO>> Post([FromBody] SystemMessage systemMessage)
        {
            SystemMessage newSystemMessage = await _SystemMessageService.addSystemMessage(systemMessage);
            return CreatedAtAction(nameof(Get), new { newSystemMessage }, newSystemMessage);
        }












    }
}
