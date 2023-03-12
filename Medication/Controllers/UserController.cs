using Microsoft.AspNetCore.Mvc;
using Services;
using DTO;
using AutoMapper;



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





        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            User u = await _userService.addUser(user);
            return user;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] User user )
        {
            await _userService.updateUser(user);
            return;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
