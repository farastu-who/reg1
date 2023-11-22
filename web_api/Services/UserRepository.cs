using System.Linq;
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

        public IList<User> GetAllUsers()
        {
            return _registrationDbContext.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _registrationDbContext.User.FirstOrDefault(u => u.Id == id);
        }

        public IList<User> GetUsersByName(string name)
        {
            return _registrationDbContext.User.Where(u => u.Name == name).ToList();
        }

        public void AddUser(User user)
        {
            _registrationDbContext.User.Add(user);
            _registrationDbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _registrationDbContext.User.Update(user);
            _registrationDbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                _registrationDbContext.User.Remove(user);
                _registrationDbContext.SaveChanges();
            }
        }
    }
}
