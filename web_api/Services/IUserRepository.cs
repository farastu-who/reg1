using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public interface IUserRepository
    {
        // Get all users
        IList<User> GetAllUsers();

        // Get a single user by ID
        User GetUserById(int id);

        // Get users by name
        IList<User> GetUsersByName(string name);

        // Add a new user
        void AddUser(User user);

        // Update an existing user
        void UpdateUser(User user);

        // Delete a user
        void DeleteUser(int id);
    }
}
