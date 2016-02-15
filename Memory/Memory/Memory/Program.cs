using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        #region Member Variables...
        static int _NumberOfRows = 4;
        static int _NumberOfColumns = 4;
        static List<List<Card>> _GameBoard = new List<List<Card>>();
        #endregion Member Variables...

        #region Main
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Memory!");
            do
            {
                Deal();
                Play();
            } while (StillPlaying());
        }
        #endregion Main

        #region Deal
        private static void Deal()
        {

            List<List<Card>> Result = new List<List<Card>>();
            int NumberOfPairs = (_NumberOfColumns * _NumberOfRows) / 2;
            List<int> Values = Enumerable.Range(1, NumberOfPairs).ToList();
            Values.AddRange(Values);
            Random Rando = new Random();

            for (int row = 0; row < _NumberOfRows; row++)
            {
                List<Card> Row = new List<Card>();
                for (int col = 0; col < _NumberOfColumns; col++)
                {
                    int Index = Rando.Next(0, Values.Count());
                    int Value = Values[Index];
                    Row.Add(new Card(Value));
                    Values.RemoveAt(Index);
                }
                Result.Add(Row);
            }
            _GameBoard = Result;
        } 
        #endregion Deal

        #region Play
        private static void Play()
        {
            while (AreSomeCardsUnFlipped())
            {
                DrawBoard();

                Console.WriteLine("Guess a card.");
                Card GuessedCard1 = GuessCard();

                Console.WriteLine("Guess another card.");
                Card GuessedCard2 = GuessCard();

                if(GuessedCard1.Value == GuessedCard2.Value)
                {
                    Console.WriteLine("Nice job!");
                }
                else
                {
                    Console.WriteLine("Nope.");
                    GuessedCard1.Flipped = false;
                    GuessedCard2.Flipped = false;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        #endregion Play

        #region Helper Methods...

        #region AreSomeCardsUnFlipped
        private static bool AreSomeCardsUnFlipped()
        {
            return _GameBoard.Any(list => list.Any(card => !card.Flipped));
        }
        #endregion AreSomeCardsUnFlipped

        #region DrawBoard
        private static void DrawBoard()
        {
            Console.Clear();
            foreach (List<Card> row in _GameBoard)
            {
                foreach (Card card in row)
                {
                    Console.Write(card.Display + "  ");
                }
                Console.WriteLine();
            }
        }
        #endregion DrawBoard

        #region GuessCoordinate
        private static Card GuessCard()
        {
            bool ValidGuess = false;
            bool AlreadyFlipped = false;
            int Row = 0;
            int Column = 0;

            do
            {
                //Guess the Row
                do
                {
                    Console.WriteLine();
                    Console.Write("Row (between 1 and " + _NumberOfRows.ToString() + "): ");
                    string RowString = Console.ReadLine();
                    if (int.TryParse(RowString, out Row) && Row > 0 && Row <= _NumberOfRows)
                    {
                        ValidGuess = true;
                        Row--;
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid choice. Try again!");
                    }
                } while (!ValidGuess);

                //Guess the Column
                ValidGuess = false;
                do
                {
                    Console.WriteLine();
                    Console.Write("Column (between 1 and " + _NumberOfColumns.ToString() + "): ");
                    string ColumnString = Console.ReadLine();
                    if (int.TryParse(ColumnString, out Column) && Column > 0 && Column <= _NumberOfColumns)
                    {
                        ValidGuess = true;
                        Column--;
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid choice. Try again!");
                    }
                } while (!ValidGuess);

                if(_GameBoard[Row][Column].Flipped)
                {
                    AlreadyFlipped = true;
                    Console.WriteLine("That card's already been flipped. Try again!");
                }
                else
                {
                    AlreadyFlipped = false;
                    _GameBoard[Row][Column].Flipped = true;
                    DrawBoard();
                }
            } while (AlreadyFlipped);
            return _GameBoard[Row][Column];
        }
        #endregion GuessCoordinate

        #region StillPlaying
        private static bool StillPlaying()
        {
            bool Result = true;

            Console.WriteLine();
            Console.Write("Do you want to play again? (Y/N): ");
            ConsoleKeyInfo Response = Console.ReadKey();
            Result = Response.KeyChar.Equals('y');

            return Result;
        }
        #endregion StillPlaying  

        #endregion Helper Methods...

    }
}
