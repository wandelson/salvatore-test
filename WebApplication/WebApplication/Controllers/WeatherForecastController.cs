using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {



        private static readonly string[] usersDb = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        [HttpGet]
        public ActionResult Get(string name )
        {

            try
            {
                var user = usersDb.Where(x => x.Contains(name)).Last();
                return Ok(user);
            }catch(Exception ex)
            {
                //log 
                return NoContent();
            }
        }
    }
}
