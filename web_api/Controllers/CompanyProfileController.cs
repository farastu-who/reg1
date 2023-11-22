using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Services;
using web_api.Services.RegistrationDb;

namespace web_api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CompanyProfileController : ControllerBase
    {
        private readonly ILogger<CompanyProfileController> _logger;
        private readonly ICompanyRepository _companyRepository;

        public CompanyProfileController(ILogger<CompanyProfileController> logger, ICompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<CompanyProfile> GetCompanyProfile(int id)
        {
            var companyProfile = _companyRepository.GetCompanyProfileById(id);
            if (companyProfile == null)
            {
                return NotFound();
            }
            return Ok(companyProfile);
        }
    }
}
