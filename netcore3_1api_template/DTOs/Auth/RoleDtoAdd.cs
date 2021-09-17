using netcore3_1api_template.Validations;
using System.ComponentModel.DataAnnotations;

namespace netcore3_1api_template.DTOs
{
    public class RoleDtoAdd
    {
        [Required]
        [FirstLetterUpperCase]
        public string RoleName { get; set; }
    }
}