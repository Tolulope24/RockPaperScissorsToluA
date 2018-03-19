using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolulope Adebayo
 * Created on: 19-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program plays Rock, Paper, Scissors between a user and the Computer 
*/

namespace RockPaperScissorsToluA
{
    public partial class frmRockPaperScissors : Form
   
    {
        public frmRockPaperScissors()
        {
            InitializeComponent();
            // Generate the random number generator
            Random randomNumberGenerator = new Random();
        }

        private void grbComputerOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 3;
            
            
            Random randomNumberGenerator = new Random();
            // get the users selection, if there is no selection, it is zero 
            playerChoice = int.Parse(grbPlayerOptions.Text);

            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
                playerChoice = 0;
            // randomly generate a ramdom number between 1 and 3 also known as Rock Paper Scissors 
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            // set the radio button fot=r the computers choice
            if (computerChoice == ROCK )
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                radComputerPaper.Checked = true;
            }
            else
            {
                this.radComputerScissors.Checked = true;
            }
        }
    }
}
