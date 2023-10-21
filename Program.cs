namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            int boardSize = 0;

            while (!isValidInput)
            {
                Console.Write("Ange önskat antal kolumner för schackbrädet: ");
                string boardDimension = Console.ReadLine();

                if (int.TryParse(boardDimension, out boardSize) && boardSize > 0)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen ange ett positivt heltal för önskat antal kolumner.");
                }
            }

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string white = "■"; // White square
            string black = "□"; // Black square

            for (int row = 0; row < boardSize; row++)
            {
                for (int column = 0; column < boardSize; column++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write(white + " ");
                    }
                    else
                    {
                        Console.Write(black + " ");
                    }
                }

                Console.WriteLine(); // Move to next row
            }
        }
    }
}