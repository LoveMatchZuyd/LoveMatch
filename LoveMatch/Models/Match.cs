namespace LoveMatch.Models
{
    public class Match
    {
        public int Id { get; set; }
        public required Member Member1 { get; set; }
        public int Member1Id { get; set; }
        public required Member Member2 { get; set; }
        public int Member2Id { get; set; }
    }
}
