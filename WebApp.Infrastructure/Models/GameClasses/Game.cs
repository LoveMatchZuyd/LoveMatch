namespace WebApp.Infrastructure.Models.GameClasses
{
    public abstract class Game
    {
        public int GameId { get; set; } = 0;

        public string Name { get; set; }
        
        public MatchedCouple MatchedPlayers { get; }
        
        public Member StartingPlayer { get; set; }
        
        public Member ActivePlayer { get; set; }
        
        public int GamesPlayed { get; set; } = 0;
        
        public Member? LastWinner { get; set; } = null;
        
        public int Member1Wins { get; set; } = 0;
        
        public int Member2Wins { get; set; } = 0;
        
        public GameBoard? Board { get; set; }
        
        public bool GameIsOver { get; set; } = false;

        public Game(string name, MatchedCouple matchedPlayers)
        {
            Name = name;
            MatchedPlayers = matchedPlayers;
            ActivePlayer = PickRandomActivePlayer();
        }
        public void StartGame()
        {
            if (LastWinner == null)
            {
                StartingPlayer = PickRandomActivePlayer();
            }

            else
            {
                if (LastWinner == MatchedPlayers.MatchedMembers[0])
                {
                    StartingPlayer = MatchedPlayers.MatchedMembers[1];
                }

                else
                {
                    StartingPlayer = MatchedPlayers.MatchedMembers[0];
                }
            }
        }

        public abstract void MakeMove();

        public void UpdateBoard() 
        {
            Board.UpdateBoard();
        }

        public abstract void CheckForWin();

        public void SwitchActivePlayer()
        {
            if (ActivePlayer == MatchedPlayers.MatchedMembers[0])
            {
                ActivePlayer = MatchedPlayers.MatchedMembers[1];
            }

            else
            {
                ActivePlayer = MatchedPlayers.MatchedMembers[0];
            }
        }

        public Member PickRandomActivePlayer()
        {
            Random startingPlayer = new Random();
            int playerIndex = startingPlayer.Next(2);
            ActivePlayer = MatchedPlayers.MatchedMembers[playerIndex];
            return ActivePlayer;
        }
    }
}

