using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly RegistrationDbContext _registrationDbContext;

        public CompanyRepository(RegistrationDbContext registrationDbContext)
        {
            _registrationDbContext = registrationDbContext;
        }

        public IList<Company> Get(int id)
        {
            return _registrationDbContext.Company.Where(c => c.Id == id).ToList();
        }

        public IList<Company> Get(string name)
        {
            return _registrationDbContext.Company.Where(c => name == c.Name).ToList();
        }

        public IList<Company> Get()
        {
           return _registrationDbContext.Company.ToList();
            // throw new NotImplementedException();
        }

        //public int Update(Company company)
        //{
        //    var updated = _registrationDbContext.Company.Attach(company);
        //    updated.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        //    return _registrationDbContext.SaveChanges();
        //}
    }
}
