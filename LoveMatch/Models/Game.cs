namespace LoveMatch.Models
{
    public class Game : Entity
    {
        public int PlayTimeInMinutes { get; set; }
        public string? Difficulty { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }

        public void ChangeDifficulty(string difficulty)
        {
            Difficulty = difficulty;
        }

        public void ChangePlayTime(int playtime)
        {
            PlayTimeInMinutes = playtime;
        }
    }
}
