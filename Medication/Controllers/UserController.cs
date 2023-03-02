using Microsoft.AspNetCore.Mvc;
using Entites;
using Services;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult< IEnumerable<User>>> Get([FromQuery]string userName, string password)
        {
            User? user = await _userService.getUser(userName, password);

            if (user !=null)
                return Ok(user);

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
