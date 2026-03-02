using System.Diagnostics;

namespace WebApp.Infrastructure.Models.GameClasses
{
    public class TicTacToe : Game
    {
        public String StartingPlayerSymbol { get; set; } = "X";
        public String SecondPlayerSymbol { get; set; } = "O";

        public int TurnsRemaining { get; set; } = 9;

        public TicTacToe(string name, MatchedCouple matchedCouple)
            : base(name, matchedCouple)
        {
            Board = new GameBoard(3, 3, this);
        }
        public override void MakeMove()  //While-loop met local bool variabele legalMove moet nog ingebouwd worden om te voorkomen dat er een legale zet gemaakt moet worden.
        {
            try
            {
                {
                    Debug.WriteLine("Welke rij wil je je symbool zetten?");
                    int row = Convert.ToInt32(Console.ReadLine());
                    if (row >= Board.NumberOfRows)
                    {
                        Debug.WriteLine("Sorry, het speelveld is te klein.");
                        return;
                    }
                    Debug.WriteLine("Welke rij wil je je symbool zetten?");
                    int column = Convert.ToInt32(Console.ReadLine());
                    if (column >= Board.RowLength)
                    {
                        Debug.WriteLine("Sorry, dit is niet mogelijk.");
                        return;
                    }

                    if (Board.Rows[row][column] != " ")
                    {
                        Debug.WriteLine($"Sorry, maar hier staat al een '{Board.Rows[row][column]}'.\nKies alstublieft een ander vakje.");
                        return;
                    }
                    else
                    {
                        if (ActivePlayer == StartingPlayer)
                        {
                            Board.Rows[row][column] = StartingPlayerSymbol;
                        }
                        else
                        {
                            Board.Rows[row][column] = SecondPlayerSymbol;
                        }
                    }
                }
                Board.UpdateBoard();
                CheckForWin();
                TurnsRemaining--;
                if (TurnsRemaining == 0)
                {
                    GameIsOver = true;
                    LastWinner = null;
                }
                SwitchActivePlayer();
            }
            catch
            {
                Debug.WriteLine("Oeps. er ging iets verkeerd");
            }
        }
        public override void CheckForWin()
        {

            while (!GameIsOver)
            {
                int checkedRows = 0;
                while (checkedRows < Board.NumberOfRows) //Hier wordt gecontroleerd of er een rij is waarin drie dezelfde tekens staan.
                {
                    if (Board.Rows[checkedRows][0] == Board.Rows[checkedRows][1] && Board.Rows[checkedRows][1] == Board.Rows[checkedRows][2])
                    {
                        GameIsOver = true;
                        LastWinner = ActivePlayer;
                        return;
                    }
                    else
                    {
                        checkedRows++;
                    }
                }
                int checkedColumns = 0;
                while (checkedColumns < Board.RowLength) //Hier wordt gecheckt of er een kolom is waarin drie dezelfde tekens staan.
                {
                    if (Board.Rows[0][checkedColumns] == Board.Rows[1][checkedColumns] && Board.Rows[1][checkedColumns] == Board.Rows[2][checkedColumns])
                    {
                        GameIsOver = true;
                        LastWinner = ActivePlayer;
                        return;
                    }
                    else
                    {
                        checkedColumns++;
                    }
                }

                if ((Board.Rows[0][0] == Board.Rows[1][1] && Board.Rows[1][1] == Board.Rows[2][2]) ||
                    (Board.Rows[0][2] == Board.Rows[1][1] && Board.Rows[1][1] == Board.Rows[2][0]))
                {
                    GameIsOver = true;
                    LastWinner = ActivePlayer;
                    return;
                }
            }
        }
    }
}
