using System.ComponentModel.DataAnnotations;

namespace Bank_Docker.Models
{
    public class User
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
