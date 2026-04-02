namespace LoveMatch.Models
{
    public class Member : Entity
    {
        public int Age { get; set; }
        public string? Bio { get; set; }
        
        public bool IsAdult()
        {
            return Age >= 18;
        }
    }
}
