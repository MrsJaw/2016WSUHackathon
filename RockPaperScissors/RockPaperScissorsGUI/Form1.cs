using RPSData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGUI
{
    public partial class Form1 : Form
    {

        #region Member Variables...

        private int _ComputerScore = 0;
        private int _UserScore = 0;
        private RockPaperScissorsData _RPSData = null;
        private Weapon _UserChoice = Weapon.Paper;
        private Weapon _ComputerChoice = Weapon.Paper;

        #endregion Member Variables...

        #region Constructors...

        public Form1()
        {
            InitializeComponent();
            _RPSData = new RockPaperScissorsData();
            ResetBoard();
        }

        #endregion Constructors...

        #region Methods...

        #region Event Handlers...

        #region buttonShoot_Click
        private void buttonShoot_Click(object sender, EventArgs e)
        {
            DisableBoard();

            if (buttonShoot.Text.Equals("SHOOT"))
            {
                if (ValidUserChoice())
                {
                    EvaluateAndDisplayWinner();
                }
                else
                {
                    buttonShoot.Enabled = true;
                }
            }
            else
            {
                ResetBoard();
            }
        }
        #endregion buttonShoot_Click

        #region radioButton_CheckedChanged
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaper.Checked)
            {
                _UserChoice = Weapon.Paper;
            }
            else if (radioButtonRock.Checked)
            {
                _UserChoice = Weapon.Rock;
            }
            else if (radioButtonScissors.Checked)
            {
                _UserChoice = Weapon.Scissors;
            }

            pictureBoxUserChoice.Image = GetImageForWeaponChoice(_UserChoice);
        }
        #endregion radioButton_CheckedChanged

        #endregion Event Handlers...

        #region DisableBoard
        private void DisableBoard()
        {
            buttonShoot.Enabled = false;
            radioButtonRock.Enabled = false;
            radioButtonScissors.Enabled = false;
            radioButtonPaper.Enabled = false;
        }
        #endregion DisableBoard

        #region EvaluateAndDisplayWinner
        private void EvaluateAndDisplayWinner()
        {
            //Reveal Computer's Answer
            pictureBoxComputerChoice.Image = GetImageForWeaponChoice(_ComputerChoice);

            //Decide Winner
            GameResult Result = _RPSData.EvaluateWinner(_ComputerChoice, _UserChoice);

            //Display result message & Update scores
            switch (Result)
            {
                case (GameResult.ComputerWins):
                    buttonShoot.Text = "I win!";
                    _ComputerScore++;
                    labelComputerScore.Text = _ComputerScore.ToString();
                    break;
                case (GameResult.UserWins):
                    buttonShoot.Text = "You win!";
                    _UserScore++;
                    labelUserScore.Text = _UserScore.ToString();
                    break;
                case (GameResult.Tie):
                    buttonShoot.Text = "I guess we're both winners!";
                    break;
            }

            //Ask to go again
            buttonShoot.Text += " Click here go again. ";
            buttonShoot.Enabled = true;
        }
        #endregion EvaluateAndDisplayWinner

        #region GetImageForWeaponChoice
        private Image GetImageForWeaponChoice(Weapon weapon)
        {
            Image WeaponChoiceImage = Properties.Resources.question;

            switch (weapon)
            {
                case (Weapon.Paper):
                    WeaponChoiceImage = Properties.Resources.paper;
                    break;
                case (Weapon.Rock):
                    WeaponChoiceImage = Properties.Resources.rock;
                    break;
                case (Weapon.Scissors):
                    WeaponChoiceImage = Properties.Resources.scissors;
                    break;
            }

            return WeaponChoiceImage;
        }
        #endregion GetImageForWeaponChoice

        #region ResetBoard
        private void ResetBoard()
        {
            buttonShoot.Text = "SHOOT";
            buttonShoot.Enabled = true;
            radioButtonRock.Enabled = true;
            radioButtonScissors.Enabled = true;
            radioButtonPaper.Enabled = true;
            radioButtonRock.Checked = true;
            pictureBoxComputerChoice.Image = Properties.Resources.question;
            _ComputerChoice = _RPSData.ChooseRandomWeapon();
        }
        #endregion ResetBoard

        #region ValidUserChoice
        private bool ValidUserChoice()
        {
            bool Result = true;

            if (!radioButtonPaper.Checked && !radioButtonRock.Checked && !radioButtonScissors.Checked)
            {
                Result = false;
            }

            return Result;
        }
        #endregion ValidUserChoice

        #endregion Methods...

    }
}
