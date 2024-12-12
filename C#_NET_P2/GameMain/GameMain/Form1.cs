/*
 * Cam Davies
 * 100944918
 * 11/10/2024
 * COSC 2100
 * This Program is  simple Tic-Tac-Toe Game for 2 players to play. It keeps score of previous games and displays a winner.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMain
{
    public partial class Form1 : Form
    {
        String[] playerNames = {"playerOne","playerTwo"};
        String[] playerSymbols = { "", "" };
        String[,] ticTacToeBoard = { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        int gameCounter = 1;
        int[] playerScores = {0,0};
        public Form1()
        {
            InitializeComponent();
        }

        // Initializez the player arrays and starts the game the Game when the start button is pressed
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isTxtBoxValid())
            {
                buttonEnableSwap("Start");
                playerNames[0] = txtBoxP1Name.Text;
                playerNames[1] = txtBoxP2Name.Text;
                playerSymbols[0] = txtBoxP1Symbol.Text;
                playerSymbols[1] = txtBoxP2Symbol.Text;
                updateValues(0, 0, "");
                
            }

        }

        // Continues to the next game when the Continue button is pressed
        private void btnContinue_Click(object sender, EventArgs e)
        {
            resetBtnText();
            buttonEnableSwap("Continue");
            playerNames[0] = txtBoxP1Name.Text;
            playerNames[1] = txtBoxP2Name.Text;
            playerSymbols[0] = txtBoxP1Symbol.Text;
            playerSymbols[1] = txtBoxP2Symbol.Text;
            updateValues(0, 0, "");

        }

        // Resets the game, and all user values when teh Reset button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetBtnText();
            buttonEnableSwap("Reset");
            Array.Clear(playerNames,0,playerNames.Length);
            Array.Clear(playerSymbols,0,playerSymbols.Length);
            playerScores[0] = 0;
            playerScores[1] = 0;
            winnersList.Items.Clear();
            txtBoxP1Name.Text = "";
            txtBoxP2Name.Text = "";
            txtBoxP1Symbol.Text = "";
            txtBoxP2Symbol.Text = "";
            txtBoxCurrentTurn.Text = "";
            txtBoxNextTurn.Text = "";
            txtBoxWinner.Text = "";
        }

        // Checks if the user inputted values are valid
        private bool isTxtBoxValid()
        {
            if (String.IsNullOrWhiteSpace(txtBoxP1Name.Text) || String.IsNullOrWhiteSpace(txtBoxP2Name.Text) || String.IsNullOrWhiteSpace(txtBoxP1Symbol.Text) || String.IsNullOrWhiteSpace(txtBoxP2Symbol.Text))
            {
                MessageBox.Show("Error: All Game Setup Boxes must be filled out");
                return false;
            }
            else if (txtBoxP1Name.Text.Equals(txtBoxP2Name.Text) || txtBoxP1Symbol.Text.Equals(txtBoxP2Symbol.Text))
            {
                MessageBox.Show("Error: Values cannot be Identical");
                return false;
            }
            else
            {
                try
                {
                    Convert.ToChar(txtBoxP1Symbol.Text);
                    Convert.ToChar(txtBoxP2Symbol.Text);
                }
                catch
                {
                    MessageBox.Show("Error: Game Symbols must be a single Character");
                    return false;
                }
            }
            return true;
        }

        // Switches the buttons enabled states depending on button pressed
        private void buttonEnableSwap(String origan)
        {
            if (origan == "Start" || origan == "Continue")
            {
                txtBoxP1Name.Enabled = false;
                txtBoxP2Name.Enabled = false;
                txtBoxP1Symbol.Enabled = false;
                txtBoxP2Symbol.Enabled = false;

                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;

                btnStart.Enabled = false;
                btnContinue.Enabled = false; 
                btnReset.Enabled = true;
                
            }
            else if (origan == "Reset")
            {
                txtBoxP1Name.Enabled = true;
                txtBoxP2Name.Enabled = true;
                txtBoxP1Symbol.Enabled = true;
                txtBoxP2Symbol.Enabled = true;

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                btnStart.Enabled = true;
                btnContinue.Enabled = false;
                btnReset.Enabled = false;
            }

        }

        //Resets all the tic-tac-toe board text, and resets tic-tac-toe array
        private void resetBtnText()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            ticTacToeBoard[0, 0] = "";
            ticTacToeBoard[0, 1] = "";
            ticTacToeBoard[0, 2] = "";
            ticTacToeBoard[1, 0] = "";
            ticTacToeBoard[1, 1] = "";
            ticTacToeBoard[1, 2] = "";
            ticTacToeBoard[2, 0] = "";
            ticTacToeBoard[2, 1] = "";
            ticTacToeBoard[2, 2] = "";
            
        }

        // Updates the values of the arrays to keep track of the tic-tac-toe board 
        private void updateValues(int indexOne, int indexTwo, String value) 
        {
            ticTacToeBoard[indexOne, indexTwo] = value;
            txtBoxCurrentTurn.Text = playerNames[0];
            txtBoxNextTurn.Text = playerNames[1];
            String dummy;
            if (value != "")
            {
                dummy = playerSymbols[0];
                playerSymbols[0] = playerSymbols[1];
                playerSymbols[1] = dummy;
            }

            dummy = playerNames[0];
            playerNames[0] = playerNames[1];
            playerNames[1] = dummy;
        }

        // Updates the winners list box, tracks game number and displays current winner
        private void updateWinners(String gameResult)
        {
            if (gameResult.Equals(txtBoxP1Symbol.Text))
            {
                winnersList.Items.Add("Game " + gameCounter + ": " + txtBoxP1Name.Text);
                playerScores[0]++;
            }
            else if (gameResult.Equals(txtBoxP2Symbol.Text))
            {
                winnersList.Items.Add("Game " + gameCounter + ": " + txtBoxP2Name.Text);
                playerScores[1]++;
            }
            else
            {
                winnersList.Items.Add("Game " + gameCounter + ": " + gameResult);
            }
            gameCounter++;

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

            btnContinue.Enabled = true;

            if (playerScores[0] > playerScores[1])
            {
                txtBoxWinner.Text = txtBoxP1Name.Text;
            }
            else if(playerScores[0] < playerScores[1])
            {
                txtBoxWinner.Text = txtBoxP2Name.Text;
            }
            else
            {
                txtBoxWinner.Text = "Tied";
            }

        }

        //This function was used from the code provided, Returns who won if there is a winner, a draw if none, and a blank if the game has not ended
        private string GetWinner(string[,] btnSymbols)
        {
            // This function will return the winning symbol
            // If there is no winner but all buttons have been clicked then it will return "Draw"
            // If there is no winner but still there are some buttons to be clicked this function returns ""


            // Lets use buret force to see if there is a winner
            // First row
            if ((btnSymbols[0, 0] != "") && (btnSymbols[0, 0] == btnSymbols[0, 1]) && (btnSymbols[0, 1] == btnSymbols[0, 2]))
            {
                return btnSymbols[0, 0]; //return winning symbol
            }

            // Second row
            if ((btnSymbols[1, 0] != "") && (btnSymbols[1, 0] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[1, 2]))
            {
                return btnSymbols[1, 0]; //return winning symbol
            }

            // Third row
            if ((btnSymbols[2, 0] != "") && (btnSymbols[2, 0] == btnSymbols[2, 1]) && (btnSymbols[2, 1] == btnSymbols[2, 2]))
            {
                return btnSymbols[2, 0]; //return winning symbol
            }

            // First col
            if ((btnSymbols[0, 0] != "") && (btnSymbols[0, 0] == btnSymbols[1, 0]) && (btnSymbols[1, 0] == btnSymbols[2, 0]))
            {
                return btnSymbols[0, 0]; //return winning symbol
            }

            // Second col
            if ((btnSymbols[0, 1] != "") && (btnSymbols[0, 1] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[2, 1]))
            {
                return btnSymbols[0, 1]; //return winning symbol
            }

            // Third col
            if ((btnSymbols[0, 2] != "") && (btnSymbols[0, 2] == btnSymbols[1, 2]) && (btnSymbols[1, 2] == btnSymbols[2, 2]))
            {
                return btnSymbols[0, 2]; //return winning symbol
            }

            // First diagonal
            if ((btnSymbols[0, 0] != "") && (btnSymbols[0, 0] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[2, 2]))
            {
                return btnSymbols[0, 0]; //return winning symbol
            }

            // Second diagonal
            if ((btnSymbols[0, 2] != "") && (btnSymbols[0, 2] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[2, 0]))
            {
                return btnSymbols[0, 2]; //return winning symbol
            }

            //There is no winner, lets see if all the buttons have a symbol, then it means its a draw, else game continues
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (btnSymbols[i, j] == "")
                        return ""; //there are some buttons still to be clicked so continue game
                }
            }

            return "Draw"; //If we have reached here then its a draw
        }

        // Updates the board when the Top Middle Button of the tic-tac-toe board is Pressed
        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = playerSymbols[0];
            updateValues(0, 1, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn2.Enabled = false;

        }

        // Updates the board when the Top Left button of the tic-tac-toe board is pressed
        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = playerSymbols[0];
            updateValues(0, 0, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn1.Enabled = false;

        }

        // Updates the board when the Top Right button of the tic-tac-toe board is pressed
        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = playerSymbols[0];
            updateValues(0, 2, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn3.Enabled = false;

        }

        // Updates the board when the Middle left button of the tic-tac-toe board is pressed
        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = playerSymbols[0];
            updateValues(1, 0, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn4.Enabled = false;

        }

        // Updates the board when the Middle button of the tic-tac-toe board is pressed
        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = playerSymbols[0];
            updateValues(1, 1, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn5.Enabled = false;

        }

        // Updates the board when the Middle Right button of the tic-tac-toe board is pressed
        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = playerSymbols[0];
            updateValues(1, 2, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn6.Enabled = false;

        }

        // Updates the board when the Bottom Left button of the tic-tac-toe board is pressed
        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = playerSymbols[0];
            updateValues(2, 0, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn7.Enabled = false;

        }

        // Updates the board when the Bottom Middle button of the tic-tac-toe board is pressed
        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = playerSymbols[0];
            updateValues(2, 1, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn8.Enabled = false;

        }

        // Updates the board when the top Bottom Right of the tic-tac-toe board is pressed
        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = playerSymbols[0];
            updateValues(2, 2, playerSymbols[0]);
            String gameResult = GetWinner(ticTacToeBoard);

            if (gameResult != "")
            {
                updateWinners(gameResult);
            }
            btn9.Enabled = false;

        }


    }
}
