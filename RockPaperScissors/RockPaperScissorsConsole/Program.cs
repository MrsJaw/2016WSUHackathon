using RPSData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsole
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            bool FirstTime = true;
            RockPaperScissorsData RPSData = new RockPaperScissorsData();

            while (StillPlaying(FirstTime))
            {
                FirstTime = false;
                Weapon ComputerChoice = RPSData.ChooseRandomWeapon();
                Weapon UserChoice = GetUserChoice();
                GameResult Result = RPSData.EvaluateWinner(ComputerChoice, UserChoice);
                DisplayWinner(ComputerChoice, Result);
            }
            Console.Read();
        }
        #endregion Main

        #region Methods...

        #region DisplayWinner
        private static void DisplayWinner(Weapon computerChoice, GameResult result)
        {
            Console.Write("I chose " + computerChoice.ToString() + ". ");
            switch (result)
            {
                case (GameResult.ComputerWins):
                    Console.Write("I win!");
                    break;
                case (GameResult.UserWins):
                    Console.Write("You win!");
                    break;
                case (GameResult.Tie):
                    Console.Write("I guess we're both winners!");
                    break;
            }
            Console.WriteLine();
        }
        #endregion DisplayWinner

        #region GetUserChoice
        private static Weapon GetUserChoice()
        {
            bool ValidChoice = false;
            Weapon Result = Weapon.Paper;

            Console.WriteLine("I've got my choice: XXXXXXXXX ");
            Console.WriteLine("What's yours?");

            while (!ValidChoice)
            {
                foreach (Weapon weapon in Enum.GetValues(typeof(Weapon)))
                {
                    Console.WriteLine(((int)weapon).ToString() + " - " + weapon.ToString());
                }

                string Answer = Console.ReadLine();
                Console.WriteLine();

                int AnswerAsInt = -1;
                if (int.TryParse(Answer, out AnswerAsInt) && Enum.IsDefined(typeof(Weapon), AnswerAsInt))
                {
                    ValidChoice = true;
                    Result = (Weapon)AnswerAsInt;
                }
                else
                {
                    Console.WriteLine("That's not an option. Try again!");
                }
            }

            return Result;
        }
        #endregion GetUserChoice

        #region StillPlaying
        private static bool StillPlaying(bool firstTime)
        {
            if (firstTime)
            {
                Console.Write("Want to play Rock, Paper, Scissors? (Y/N) ");
            }
            else
            {
                Console.Write("Wanna go again? (Y/N)");
            }
            ConsoleKeyInfo Answer = Console.ReadKey();
            Console.WriteLine();
            return (Answer.Key == ConsoleKey.Y);
        }
        #endregion StillPlaying

        #endregion Methods...

    }
}
