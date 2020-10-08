using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace conferencia_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int val1, int val2)
        {
            Operaciones op = new Operaciones();
            int resultado = op.multiplicacion(op.multiplicacion(op.suma(op.suma(val1,val2),op.suma(val1,val2)),op.suma(op.suma(val1,val2),op.suma(val1,val2))),op.suma(op.suma(val1,val2),op.suma(val1,val2)));
            return new string[] { resultado.ToString() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
