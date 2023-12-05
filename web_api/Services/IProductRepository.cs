using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public interface IProductRepository
    {
        IList<Product> GetAll();

        IList<Product> GetById(int id);

        int Create(Product product);

        int Update(Product product);
    }
}
