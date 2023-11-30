using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly RegistrationDbContext _registrationDbContext;

        public UserRepository(RegistrationDbContext registrationDbContext)
        {
            _registrationDbContext = registrationDbContext;
        }

        public IList<User> GetAllByCompany(int id)
        {
            return _registrationDbContext.User.Where(u => u.CompanyId == id).ToList();
        }
    }
}
