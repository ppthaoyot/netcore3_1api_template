using System.ComponentModel.DataAnnotations;

namespace netcore3_1api_template.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}