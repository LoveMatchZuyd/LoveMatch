namespace LoveMatch.Models
{
    // Created by W. Smeets
    public class Match
    {
        public int Id { get; set; }
        public required List<Member> Members { get; set; }
    }
}
