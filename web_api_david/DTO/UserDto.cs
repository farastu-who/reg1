using System.ComponentModel.DataAnnotations;

namespace web_api.DTO
{
    public class UserDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
