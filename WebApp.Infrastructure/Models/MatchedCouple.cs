using WebApp.Infrastructure.Models.GameClasses;

namespace WebApp.Infrastructure.Models
{
    public class MatchedCouple
    {
        public int Id { get; set; } = 0;
        public List<Member> MatchedMembers { get; } = new List<Member>();

        public List<Game> GamesPlaying { get; set; } = new List<Game>();

        public Game? CurrentGame { get; set; }

        public MatchedCouple(Member member1, Member member2)
        {
            MatchedMembers.Add(member1);
            MatchedMembers.Add(member2);
        }

        public Game StartNewGame(Game game)
        {
            GamesPlaying.Add(game);
            CurrentGame = game;
            return CurrentGame;
        }
    }
}
