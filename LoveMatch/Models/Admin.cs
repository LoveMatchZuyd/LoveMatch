using Microsoft.AspNetCore.Identity;

namespace LoveMatch.Models
{
    public class Admin : Entity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsSuperAdmin { get; set; }
    }
}
