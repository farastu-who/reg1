using web_api.Services.RegistrationDb;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace web_api.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly RegistrationDbContext _registrationDbContext;

        public ProductRepository(RegistrationDbContext registrationDbContext)
        {

            _registrationDbContext = registrationDbContext;
        }


        public int Create(Product product)
        {
            _registrationDbContext.Product.Add(product);

            return _registrationDbContext.SaveChanges();
        }

        public IList<Product> GetAll()
        {
            return _registrationDbContext.Product.ToList();
        }

        public IList<Product> GetById(int id)
        {
            return _registrationDbContext.Product.Where(p => p.Id == id).ToList();
        }

        public int Update(Product product)
        {
            var updated = _registrationDbContext.Product.Attach(product);
            updated.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return _registrationDbContext.SaveChanges();
        }
    }
}
