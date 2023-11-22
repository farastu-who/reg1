using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Services;
using web_api.Services.RegistrationDb;

namespace web_api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }
    }
}
