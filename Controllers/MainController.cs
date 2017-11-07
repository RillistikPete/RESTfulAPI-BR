using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTful_API_17.Controllers
{
    [Route("/[controller]")]
    public class MainController : Controller
    {
        // GET /main
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /main/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST /main
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT /main/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE /main/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
