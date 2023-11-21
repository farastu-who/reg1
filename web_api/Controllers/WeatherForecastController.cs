using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using web_api.Services;
using web_api.Services.RegistrationDb;

namespace web_api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICompanyRepository _companyRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Company> Get()
        {
             return _companyRepository.Get().ToArray();
           // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
          //  {
            //    Date = DateTime.Now.AddDays(index),
              //  TemperatureC = Random.Shared.Next(-20, 55),
               // Summary = Summaries[Random.Shared.Next(Summaries.Length)]
          //  })
           // .ToArray();
        }
    }
}