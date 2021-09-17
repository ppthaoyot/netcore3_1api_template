using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore3_1api_template.Models.Auth
{
    [Table("User", Schema = "auth")]
    public class User : IId
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        public string CreatedDate { get; set; }
    }
}