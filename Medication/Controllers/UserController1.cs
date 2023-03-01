﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController1 : ControllerBase
    {
        // GET: api/<UserController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}