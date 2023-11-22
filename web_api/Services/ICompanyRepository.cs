using web_api.Services.RegistrationDb;

namespace web_api.Services
{
    public interface ICompanyRepository
    {
        // get all companies
        IList<Company> Get();
        IList<Company> Get(int id);
        IList<Company> Get(string name);
        //int Update(Company company);

        // Additional methods for updating, deleting, etc., can be added here
    }
}
