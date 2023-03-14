using Microsoft.AspNetCore.Mvc;
using Services;
using DTO;
using AutoMapper;
using Entites;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper= mapper;
        }

        // GET: api/<UserController>
        [HttpGet, ]
        public async Task<ActionResult <UserDTO>> Get([FromQuery]string userName, string password)
        {

            if (_userService.getUser(userName, password) != null)
            {
                User user = await _userService.getUser(userName, password);
                UserDTO userDTO = _mapper.Map<UserDTO> (user); 
                return Ok(userDTO);
            }   
           
            return NotFound();
        }


        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] UserDTO UDto)
        {

            User UserDTO = _mapper.Map<UserDTO, User>(UDto);
            User u = await _userService.addUser(UserDTO);
            return u;

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put([FromBody] UserDTO userToUpdate)
        {

            var user = _mapper.Map<UserDTO, User>(userToUpdate);
            if (user != null)
                await _userService.updateUser(user);
            return;
        }
       
    }
}
