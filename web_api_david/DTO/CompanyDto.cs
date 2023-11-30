using System.ComponentModel.DataAnnotations;

namespace web_api.DTO
{
    public class CompanyDto
    {
        [Required]
        public int Id { get; set; }

        public bool IsTrial { get; set; }
        
        public bool VsoApproval { get; set; }
        
        public bool Status { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public IList<AddressDto> Address { get; set; }

        [Required]
        public IList<ProductDto> LicensedProducts { get; set; }

        public UserDto PrimaryContact { get; set; }

        public IList<UserDto> Users { get; set; }
    }
}
