using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public interface IUserRepository
    {
        IList<User> GetAllByCompany(int id);
    }
}
