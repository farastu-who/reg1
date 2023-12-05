using System.ComponentModel.DataAnnotations;

namespace web_api.DTO
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
