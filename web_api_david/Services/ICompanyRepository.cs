using web_api.DTO;

namespace web_api.Services
{
    public interface ICompanyRepository
    {
        IList<CompanyDto> GetAll();

        CompanyDto GetById(int id);
        
        CompanyDto GetByName(string name);
        
        int Create(CompanyDto CompanyDTO);
        
        int Update(CompanyDto CompanyDTO);
    }
}
