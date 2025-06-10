using Microsoft.AspNetCore.Identity;

namespace AuthTemplateAPI.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}

