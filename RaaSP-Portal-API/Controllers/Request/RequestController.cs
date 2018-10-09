using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaaSP_Portal_Business.Authentication;

namespace RaaSP_Portal_API.Controllers.Request
{
    [Authorize]
    [Route("api/request/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        // GET api/request/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/request/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/request/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO:Handle User Approval
            AuthenticationController.DirectAuthenticationMethod("SAML","","");

        }

        // PUT api/request/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/request/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
