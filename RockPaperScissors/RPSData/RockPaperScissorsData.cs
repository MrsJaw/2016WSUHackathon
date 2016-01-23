using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSData
{
    public class RockPaperScissorsData
    {
        #region Member Variables...

        private int _MaxWeaponValue = Enum.GetValues(typeof(Weapon)).Cast<int>().Max();
        private Dictionary<Weapon, List<Weapon>> _WeaponRelation;
        private Random _Rando = null;

        #endregion Member Variables...

        #region Constructors...

        public RockPaperScissorsData()
        {
            _Rando = new Random();
            BuildRelations();
        }

        #endregion Constructors...

        #region Methods...

        #region BuildRelations
        private void BuildRelations()
        {
            _WeaponRelation = new Dictionary<Weapon, List<Weapon>>();

            for (int i = 0; i <= _MaxWeaponValue; i++)
            {
                Weapon CurrentWeapon = (Weapon)i;
                List<Weapon> BeatenWeapons = new List<Weapon>();

                switch (CurrentWeapon)
                {
                    case (Weapon.Rock):
                        BeatenWeapons.Add(Weapon.Scissors);
                        break;
                    case (Weapon.Paper):
                        BeatenWeapons.Add(Weapon.Rock);
                        break;
                    case (Weapon.Scissors):
                        BeatenWeapons.Add(Weapon.Paper);
                        break;
                }
                _WeaponRelation.Add(CurrentWeapon, BeatenWeapons);
            }
        }
        #endregion BuildRelations

        #region ChooseRandomWeapon
        public Weapon ChooseRandomWeapon()
        {
            return (Weapon)_Rando.Next(_MaxWeaponValue + 1);
        }
        #endregion ChooseRandomWeapon

        #region EvaluateWinner
        public GameResult EvaluateWinner(Weapon computerChoice, Weapon userChoice)
        {
            GameResult Result = GameResult.Tie;

            if (_WeaponRelation[computerChoice].Contains(userChoice))
            {
                Result = GameResult.ComputerWins;
            }
            else if(_WeaponRelation[userChoice].Contains(computerChoice))
            {
                Result = GameResult.UserWins;
            }

            return Result;
        }
        #endregion EvaluateWinner

        #endregion Methods...
    }
}
