using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace TspuWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        [HttpGet("{count}")] 
        public ActionResult<int[]> Get([FromRoute] int count)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for(int x = 0; x<array.Length; x++)
            {
                array[x] = rand.Next();
            }
            return Ok(array);
        }
    }
}
