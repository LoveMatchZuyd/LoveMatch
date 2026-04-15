using NuGet.DependencyResolver;

namespace LoveMatch.Models
{
    public class Member : Entity
    {
        public DateTime DateOfBirth { get; set; }
        public string? Bio { get; set; }

        public Admin Admin { get; set; }
        public int AdminId { get; set; }

        public bool IsAdult()
        {
            int currentYear = DateTime.Now.Year;

            return (currentYear - DateOfBirth.Year) >= 18;
        }
    }
}
