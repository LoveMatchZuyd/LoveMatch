namespace LoveMatch.Models
{
    public class Match
    {
        public int Id { get; set; }
        public required List<Member> Members { get; set; }
    }
}
