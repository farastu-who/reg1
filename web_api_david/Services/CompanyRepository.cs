using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.Entity.Infrastructure;
using web_api.DTO;
using web_api.Services.RegistrationDb;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace web_api.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly RegistrationDbContext _registrationDbContext;

        public CompanyRepository(RegistrationDbContext registrationDbContext)
        {
            _registrationDbContext = registrationDbContext;
        }

        private int CreateAddress(AddressDto addressDto)
        {
            if (addressDto == null)
                return 0;

            var address = new Address();
            address.AddressLine1 = addressDto.Line1;
            address.AddressLine2 = addressDto.Line2;
            address.DateCreated = DateTime.UtcNow;
            address.City = addressDto.City;
            address.Country = addressDto.Country;
            address.PostalCode = addressDto.PostalCode;
            address.StateProvince = addressDto.State;

            _registrationDbContext.Add(address);
            _registrationDbContext.SaveChanges();

            return address.Id;
        }

        public int Create(CompanyDto companyDto)
        {
            if (companyDto == null)
                return 0;

            var addresdId = CreateAddress(companyDto.Address.FirstOrDefault());

            if (addresdId < 0)
                return 0;

            var company = new Company();
            company.Name = companyDto.Name;
            company.Code = new Guid();
            company.IsActive = true;
            company.AddressId = addresdId;

            _registrationDbContext.Company.Add(company);

            return _registrationDbContext.SaveChanges();
        }

        public IList<CompanyDto> GetAll()
        {
            var companiesDto = new List<CompanyDto>();
            var companies = _registrationDbContext.Company.ToList();

            foreach (var c in companies)
            {
                var companyDto = new CompanyDto();
                companyDto.Name = c.Name;
                companyDto.Id = c.Id;

                companiesDto.Add(companyDto);   
            }

            return companiesDto;
        }

        public CompanyDto GetById(int id)
        {
            var compnayDto = new CompanyDto();
            var company = _registrationDbContext.Company.Where(c => c.Id == id).FirstOrDefault();

            compnayDto.Name = company.Name;
            compnayDto.Id = company.Id;

            return compnayDto;
        }

        public CompanyDto GetByName(string name)
        {
            var compnayDto = new CompanyDto();
            var company = _registrationDbContext.Company.Where(c => c.Name == name).FirstOrDefault();

            compnayDto.Name = company.Name;
            compnayDto.Id = company.Id;

            return compnayDto;
        }

        public int Update(CompanyDto companyDto)
        {
            var company = new Company();
            company.Name = companyDto.Name;
            company.Id = companyDto.Id;

            _registrationDbContext.Company.Attach(company);

            return _registrationDbContext.SaveChanges();
        }
    }
}
