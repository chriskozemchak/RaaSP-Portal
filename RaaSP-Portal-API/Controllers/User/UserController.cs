using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaaSP_Portal_Business;

namespace RaaSP_Portal_API.Controllers.User
{
    [Authorize]
    [Route("api/user/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/user/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/user/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/user/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/user/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/user/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
