namespace LoveMatch.Models
{
    public class Game : Entity
    {
        public int PlayTimeInMinutes { get; set; }
        public string? Difficulty { get; set; }
    }
}
