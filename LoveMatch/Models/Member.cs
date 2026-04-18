using NuGet.DependencyResolver;

namespace LoveMatch.Models
{
    public class Member : Entity
    {
        public DateTime DateOfBirth { get; set; }
        public string? Bio { get; set; }
        public List<Game>? Games { get; set; }

        public List<Match>? Matches { get; set; }
        public required Admin Admin { get; set; }
        public int AdminId { get; set; }

        public bool IsAdult()
        {
            DateTime currentYear = DateTime.Now;

            if ((currentYear.Year - DateOfBirth.Year) <= 17)
            {
                return false;
            }
            else if (((currentYear.Year - DateOfBirth.Year) == 18) && (currentYear.DayOfYear < DateOfBirth.DayOfYear))
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
