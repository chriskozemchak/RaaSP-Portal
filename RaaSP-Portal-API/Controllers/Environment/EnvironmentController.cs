using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaaSP_Portal_Business;

namespace RaaSP_Portal_API.Controllers.Environment
{
    [Authorize]
    [Route("api/environment/[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        // GET api/environment/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/environment/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/environment/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/environment/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/environment/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
