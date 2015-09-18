using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class GuessingGame : Form
    {
        int theNumber;// The random number


        //Random requirment
        Random myRandom = new Random();

       
        bool wrong = true;

        public GuessingGame()
        {
            InitializeComponent();
            theNumber = myRandom.Next(10);


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (theNumber == Convert.ToInt32(InputBox.Text))
                {
                    MessageBox.Show("Guess is correct - you win!");
                    wrong = false;

                    DialogResult result = MessageBox.Show("Would you like to play again?",
                    "Play Again", MessageBoxButtons.YesNo);

                    if (result.ToString().ToLower() == "yes")
                    {
                        InputBox.Clear();
                        InputBox.Text = myRandom.Next(10).ToString();
                        theNumber = myRandom.Next(10);
                        MessageBox.Show("Lets see if random and guess random!");
                    }

                    else if (result.ToString().ToLower() == "no")
                    {
                        //add want ever makes it close...
                        Application.Exit();

                    }


                }

                if (theNumber > Convert.ToInt32(InputBox.Text))
                {
                    MessageBox.Show("Guess is too low, please try again"); // added + theNumber for debug
                                                                           //wrong = true;
                }

                if (theNumber < Convert.ToInt32(InputBox.Text))
                {
                    MessageBox.Show("Guess is too high, please try again ");
                    // wrong = true;
                }
            }

            catch (Exception ex)
            {
                //Show error
                MessageBox.Show("Please enter a valid number!\nMessage: " + ex.Message);

                //Clear values from textboxes
                InputBox.Clear();
                InputBox.Text = myRandom.Next(10).ToString(); // Adds a random number 

            }
            

        }
    }
}
