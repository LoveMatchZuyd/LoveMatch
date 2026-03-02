using System.Diagnostics;

namespace WebApp.Infrastructure.Models.GameClasses
{
    public class Nim : Game
    {
        public int StartingNumber { get; set; } = 23;

        public int CurrentNumber { get; set; }

        public int SubstractValue1 { get; set; } = 1;
        public int SubstractValue2 { get; set; } = 2;
        public int SubstractValue3 { get; set; } = 3;

        public Nim(string name, MatchedCouple matchedCouple) :
            base(name, matchedCouple)
        {
            CurrentNumber = StartingNumber = 23;
            DetermineSize(CurrentNumber);
        }

        public override void MakeMove()
        {
            try
            {
                Debug.WriteLine($"{ActivePlayer.FirstName}. Hoeveel wilt u van {CurrentNumber} aftrekken?\n" +
                    $"1. Ik wil er {SubstractValue1} van aftrekken\n" +
                    $"2. Ik wil er {SubstractValue2} van aftrekken\n" +
                    $"3. Ik wil er {SubstractValue3} van aftrekken\n" +
                    $"Uw Keuze: ");

                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput >= 1 && userinput <= 3)
                {
                    if (userinput == 1 && SubstractValue1 <= CurrentNumber)
                    {
                        ChangeValue(SubstractValue1);
                    }
                    else if (userinput == 2 && SubstractValue2 <= CurrentNumber)
                    {
                        ChangeValue(SubstractValue2);
                    }
                    else if (userinput == 3 && SubstractValue3 <= CurrentNumber)
                    {
                        ChangeValue(SubstractValue3);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

                CheckForWin();
                SwitchActivePlayer();
            }

            catch (FormatException)
            {
                Debug.WriteLine("Sorry, ik kan enkel de waarden 1, 2, en 3 accepteren.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.WriteLine("Sorry, de waarde die jij hebt gegeven is te hoog.");
            }

        }

        public void ChangeValue(int substractionValue)
        {
            CurrentNumber -= substractionValue;
            DetermineSize(CurrentNumber);
        }

        public void DetermineSize(int currentValue)
        {
            int GridSize = Convert.ToInt32(Math.Ceiling(Math.Sqrt(currentValue)));
            Board = new GameBoard(GridSize, GridSize, this);
            Console.Clear();
            FillMatrix(currentValue);
            Board.UpdateBoard();
        }

        public void FillMatrix(int currentValue)
        {
            int numberOfBlocks = currentValue;

            foreach (var row in Board.Rows)
            {
                int cellsFilled = 0;
                while (numberOfBlocks != 0 && cellsFilled < Board.RowLength)
                {
                    row[cellsFilled] = "O";
                    cellsFilled++;
                    numberOfBlocks--;
                }
            }
        }

        public override void CheckForWin()
        {
            if (CurrentNumber == 0)
            {
                GameIsOver = true;
                LastWinner = ActivePlayer;
                return;
            }
        }

    }
}
