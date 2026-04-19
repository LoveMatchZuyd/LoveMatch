using Microsoft.AspNetCore.Identity;

namespace LoveMatch.Models
{
    // Created by B. Malasch
    public class Admin : Entity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public List<Member>? Members { get; set; }
        public bool IsSuperAdmin { get; set; }
    }
}
