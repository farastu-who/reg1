using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public interface IProductRepository
    {
        // Get all products
        IList<Product> GetAllProducts();

        // Get a single product by ID
        Product GetProductById(int id);

        // Get products by name
        IList<Product> GetProductsByName(string name);

        // Additional methods for updating, deleting, etc., can be added here
    }
}
