using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker;
using LambdaExpressionParameter.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LambdaExpressionParameter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            var randomPerson = new Person();
            randomPerson.GenerateRandomName(() =>
            {
                return new Person()
                {
                    FirstName = Name.First(),
                    LastName = Name.Last()
                };
            });
            Console.WriteLine($"{randomPerson.FirstName} {randomPerson.LastName}"); 
            randomPerson.Mutate(x => x.ToUpper());
            Console.WriteLine($"{randomPerson.FirstName} {randomPerson.LastName}"); 
        }
    }
    
}
