namespace LoveMatch.GameFetcher.API.Models;

public class FetchedGame
{
    public int Id { get; set; } 

    public string Name { get; set; }
    public int? PlayTimeInMinutes { get; set; }
    public string? Difficulty { get; set; }

    public void ChangeDifficulty(string difficulty)
    {
        Difficulty = difficulty;
    }

    public void ChangePlayTime(int playtime)
    {
        PlayTimeInMinutes = playtime;
    }
}
