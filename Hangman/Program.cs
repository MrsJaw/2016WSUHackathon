using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory
{
    class Program
    {
        #region Member Variables...
        static bool _StillMissingLetters = true;
        static int _NumberOfMistakes = 0;
        static List<char> _GuessedLetters = new List<char>();
        static List<char> _Letters = new List<char>("abcdefghijklmnopqrstuvwxyz");
        static Dictionary<int, string> _GameBoard = new Dictionary<int, string>();
        static List<string> _WordList = new List<string>();
        static string _Word = "hello";
        #endregion Member Variables...

        #region Main
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Hangman!\r\nPress any key to continue.");
            Console.Read();
            do
            {
                SetUpGame();
                Play();
            } while (StillPlaying());
        }
        #endregion Main

        #region Helper Methods...

        #region DrawBoard
        private static void DrawBoard(string message = "")
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Guessed Letters: " + string.Join(", ", _GuessedLetters));
            Console.WriteLine();
            Console.Write(_GameBoard[_NumberOfMistakes]);
            Console.WriteLine();

            _StillMissingLetters = false;
            foreach (char c in _Word)
            {
                if (_GuessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                }
                else
                {
                    _StillMissingLetters = true;
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion DrawBoard

        #region Play
        private static void Play()
        {
            Random RandoCardrizian = new Random();
            string Message = string.Empty;

            _Word = _WordList[RandoCardrizian.Next(_WordList.Count - 1)];
            DrawBoard();

            while ((_NumberOfMistakes < _GameBoard.Keys.Count() - 1) && _StillMissingLetters)
            {
                bool ValidGuess = false;
                char GuessedLetter = '*';

                do
                {
                    Console.WriteLine("Guess a letter:");
                    GuessedLetter = Console.ReadKey().KeyChar;
                    ValidGuess = _Letters.Contains(GuessedLetter) && !_GuessedLetters.Contains(GuessedLetter);                                       
                } while (!ValidGuess);

                _GuessedLetters.Add(GuessedLetter);

                if(_Word.Contains(GuessedLetter))
                {
                    Message = "Correct!!";
                }
                else
                {
                    _NumberOfMistakes++;
                    Message = "OH NO!!";
                }

                DrawBoard(Message);
            }

            DrawBoard();
            if(_StillMissingLetters)
            {
                Console.WriteLine("You done goofed. The word was " + _Word);
            }
            else
            {
                Console.WriteLine("YOU DID IT!! THE STICK PERSON LIVES!!\r\n (we should rethink our criminal justice system....)");
            }
        }
        #endregion Play

        #region SetUpGame
        private static void SetUpGame()
        {
            //Clear guesses
            _GuessedLetters = new List<char>();
            _NumberOfMistakes = 0;

            //Read in Words
            if (_WordList.Count == 0)
            {
                _WordList = HangmanConsole.Properties.Resources.wordlist.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            }
            else
            {
                _WordList.Remove(_Word); //or remove the last one used
            }

            //Read in Board
            if (_GameBoard.Count == 0)
            {
                int i = 0;
                _GameBoard = new Dictionary<int, string>();
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.NewGameBoard);
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.OneMistake);
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.TwoMistakes);
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.ThreeMistakes);
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.FourMistakes);
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.FiveMistakes);
                _GameBoard.Add(i++, HangmanConsole.Properties.Settings.Default.GameLost);
            }
        }
        #endregion SetUpGame

        #region StillPlaying
        private static bool StillPlaying()
        {
            bool Result = true;

            if (_WordList.Count > 0)
            {
                Console.WriteLine();
                Console.Write("Do you want to play again? (Y/N): ");
                ConsoleKeyInfo Response = Console.ReadKey();
                Result = Response.KeyChar.Equals('y');
            }
            else
            {
                Result = false;
            }

            return Result;
        }
        #endregion StillPlaying  

        #endregion Helper Methods...

    }
}
