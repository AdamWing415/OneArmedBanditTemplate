using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random slot = new Random();

        // int value for score initialized to 10
        int coins = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            outputLabel.ResetText();
            outputLabel.Refresh();
            coins--;
            scoreDisplay.Text = coins + "";

            int slot1 = slot.Next(1, 4);
            int slot2 = slot.Next(1, 4);
            int slot3 = slot.Next(1, 4);

            // get random values for each reel (store each in separate int variable)

            int i = 1;

            while (i < 25)
            {
                slot1 = slot.Next(1, 4);
                slot2 = slot.Next(1, 4);
                slot3 = slot.Next(1, 4);

                // check value of reel 1 with a switch statement and set appropriate image
                switch (slot1)
                {
                    case 1:
                        reel1.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel1.Image = Properties.Resources.diamond_100x125;
                        break;
                    case 3:
                        reel1.Image = Properties.Resources.cherry_100x125;
                        break;
                }

                // check value of reel 2 with a switch statement and set appropriate image
                switch (slot2)
                {
                    case 1:
                        reel2.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel2.Image = Properties.Resources.diamond_100x125;
                        break;
                    case 3:
                        reel2.Image = Properties.Resources.cherry_100x125;
                        break;
                }


                // check value of reel 3 with a switch statement and set appropriate image
                switch (slot3)
                {
                    case 1:
                        reel3.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel3.Image = Properties.Resources.diamond_100x125;
                        break;
                    case 3:
                        reel3.Image = Properties.Resources.cherry_100x125;
                        break;

                }
                reel1.Refresh();
                reel2.Refresh();
                reel3.Refresh();
                Thread.Sleep(90);
                i++;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (slot1 == 1 && slot2 == 1 && slot3 ==1 || slot1 == 2 && slot2 == 2 && slot3 == 2 || slot1 == 3 && slot2 == 3 && slot3 == 3)
            {
                coins = coins + 3;
                scoreDisplay.Text = coins + "";
                outputLabel.Text = "WINNER!";
                
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (coins == 0)
            {
                spinButton.Enabled = false;
                outputLabel.Text = "HAHA LOSER";
            }
        }
    }
}
