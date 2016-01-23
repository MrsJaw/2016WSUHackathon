using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSData
{
    #region Weapon
    public enum Weapon
    {
        Rock,
        Paper,
        Scissors /*,
        Lizard,
        Spock*/
    }
    #endregion Weapon

    #region GameResult
    public enum GameResult
    {
        Tie,
        ComputerWins,
        UserWins
    }
    #endregion GameResult
}
