using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api.DTO;
using web_api.Services;

namespace web_api.Controllers
{
    // TO-DO: Authentication - Authorization
    [Route("api/[controller]")]
    [ApiController]
    public class UIController : ControllerBase
    {
        private readonly ILogger<UIController> _logger;
        private readonly ICompanyRepository _companyRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;

        public UIController(ILogger<UIController> logger, ICompanyRepository companyRepository, IProductRepository productRepository, IUserRepository userRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _productRepository = productRepository;
            _userRepository = userRepository;
        }


        // TO-DO: Role-based Access Control
        [HttpGet]
        public IEnumerable<CompanyDto> GetAll()
        {
            var companies = _companyRepository.GetAll();


            return companies;
        }

    }
}
