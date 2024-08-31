using Microsoft.AspNetCore.Mvc;

namespace IOptionsPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ITransientServices _services;

        public WeatherForecastController(ITransientServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("/test/transient")]
        public IActionResult GetData()
        {
            return Ok(_services.Get());
        }
    }
}
