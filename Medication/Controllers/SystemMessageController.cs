using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO;
using AutoMapper;
using Services;
using System.Xml.Linq;
using Entites;

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
        public async Task<ActionResult<IEnumerable<SystemMessageDTO>>> Get([FromQuery] int userId)
        {
            IEnumerable<SystemMessage> systemMessages = await _SystemMessageService.getSystemMessages(userId);

            IEnumerable<SystemMessageDTO> msDTO = _mapper.Map<IEnumerable<SystemMessage>, IEnumerable<SystemMessageDTO>>(systemMessages);

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
            //mapper - להחזיר dto

            return CreatedAtAction(nameof(Get), new { newSystemMessage }, newSystemMessage);
        }

        
        [HttpPut("{id}")]
        public async void Put([FromBody] SystemMessage systemMessage)
        {
            await _SystemMessageService.updateSystemMessage(systemMessage);
            return;
        }













    }
}
