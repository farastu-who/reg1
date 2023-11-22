using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Services;
using web_api.Services.RegistrationDb;

namespace web_api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ILogger<CompaniesController> _logger;
        private readonly ICompanyRepository _companyRepository;

        public CompaniesController(ILogger<CompaniesController> logger, ICompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> GetCompanies()
        {
            var companies = _companyRepository.GetAllCompanies();
            return Ok(companies);
        }

        [HttpGet("{id}")]
        public ActionResult<Company> GetCompany(int id)
        {
            var company = _companyRepository.GetCompanyById(id);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }
    }
}
