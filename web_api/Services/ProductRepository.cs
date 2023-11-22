using System.Linq;
using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly RegistrationDbContext _registrationDbContext;

        public ProductRepository(RegistrationDbContext registrationDbContext)
        {
            _registrationDbContext = registrationDbContext;
        }

        public IList<Product> GetAllProducts()
        {
            return _registrationDbContext.Product.ToList();
        }

        public Product GetProductById(int id)
        {
            return _registrationDbContext.Product.FirstOrDefault(p => p.Id == id);
        }

        public IList<Product> GetProductsByName(string name)
        {
            return _registrationDbContext.Product.Where(p => p.Name == name).ToList();
        }

        // Additional methods for updating, deleting, etc., can be implemented here
    }
}
