using System.ComponentModel.DataAnnotations;

namespace AuthTemplateAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}

