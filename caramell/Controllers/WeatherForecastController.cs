using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using caramell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace caramell.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private DataBaseContext db;
        public WeatherForecastController(DataBaseContext context, ILogger<WeatherForecastController> logger)
        {
            db = context;
            _logger = logger;

        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("[action]")]
        public IEnumerable<User> GetUsers()
        {

            User user = new User() { Name = "test", CreateDate = DateTime.Now, Login = "admin", Pwd = "test", RoleId = 1, Surname = "admon", MiddleName = "dantes" };
            db.Users.Add(user);
            db.SaveChanges();

            var users = db.Users.ToList();

            return users;
        }
    }
}
