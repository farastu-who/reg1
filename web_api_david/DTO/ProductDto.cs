using System.ComponentModel.DataAnnotations;

namespace web_api.DTO
{
    public class ProductDto
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsInternal { get; set; }
    }
}
