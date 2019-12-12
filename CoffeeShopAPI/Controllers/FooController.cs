using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FooController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FooController> _logger;

        public FooController(ILogger<FooController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string> { "foo", "bar", "baz", "from the foo comntroller" };
        }

        [HttpGet]
        public IEnumerable<string> Post()
        {
            return new List<string> { "this", "is", "a", "post request" };
        }

        [HttpGet("{id}")]
        public IEnumerable<string> GetOne( string id)
        {
            //return new List<string> { "I", "got", "one" };
            return new Employee
            {
                FirstName = "",
                LastName = "",
                Id = ""
            };
        }

        [HttpPost]
        public IEnumerable<string> AddAFoo()
        {
            return new List<string> { "this", "is", "a", "post request" };
        }

    }

}
