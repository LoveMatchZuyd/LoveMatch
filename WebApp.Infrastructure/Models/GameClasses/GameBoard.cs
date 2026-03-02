namespace WebApp.Infrastructure.Models.GameClasses
{
    public class GameBoard
    {
        public int Id { get; set; } = 0;
        public List<List<String>> Rows { get; set; } = new List<List<String>>();
        public int RowLength { get; set; }

        public int NumberOfRows { get; set; }

        public Game AssociatedGame { get; set; }

        public GameBoard(int rowLength, int numberOfRows, Game associatedGame)
        {
            RowLength = rowLength;
            NumberOfRows = numberOfRows;
            AssociatedGame = associatedGame;
            Rows = GenerateRows();
        }

        public List<List<String>> GenerateRows()
        {
            int rowsMade = 0;
            while (rowsMade < NumberOfRows)
            {
                List<string> newRow = new List<string>();
                int cellNumber = 0;
                while (cellNumber < RowLength)
                {
                    newRow.Add(" ");
                    cellNumber++;
                }
                Rows.Add(newRow);
                rowsMade++;
            }
            foreach (var row in Rows)
            {
                Console.WriteLine(string.Join(" | ", row));
            }
            return Rows;
        }

        public void UpdateBoard()  //Voorlopig wordt het speelveld getoond in een console. Wordt later omgebouwd om de API te laten weten hoe het nieuwe bord er uitziet.
        {
            foreach (var row in Rows)
                Console.WriteLine(string.Join(" | ", row));

        }
    }
}
