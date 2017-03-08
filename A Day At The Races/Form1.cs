using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Guy GuyBet = new Guy();
        PictureBox[] dog = new PictureBox[4];
        
        bool BetPlaced = false;
        bool lockRace = false;
        int minBet = 5;


        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "$" + minBet + " minimum bet!";


            GreyhoundArray[0] = new Greyhound()
                {
                    MyPictureBox = dog1,
                    StartingPosition = dog1.Left,
                    RacetrackLength = racetrackPicture.Width - dog1.Width,
                    Randomizer = random
                };

            GreyhoundArray[1] = new Greyhound()
                {
                    MyPictureBox = dog2,
                    StartingPosition = dog2.Left,
                    RacetrackLength = racetrackPicture.Width - dog2.Width,
                    Randomizer = random
                };

            GreyhoundArray[2] = new Greyhound()
                {
                    MyPictureBox = dog3,
                    StartingPosition = dog3.Left,
                    RacetrackLength = racetrackPicture.Width - dog3.Width,
                    Randomizer = random
                };

            GreyhoundArray[3] = new Greyhound()
                {
                    MyPictureBox = dog4,
                    StartingPosition = dog4.Left,
                    RacetrackLength = racetrackPicture.Width - dog4.Width,
                    Randomizer = random
                };


            // setup guy array
            GuyArray[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = joeRadioButton, MyLabel = joeBetLabel };
            GuyArray[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = bobRadioButton, MyLabel = bobBetLabel };
            GuyArray[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = alRadioButton, MyLabel = alBetLabel};

            // clearing bets on startup
            for (int i = 0; i < 3; i++)
            {
                GuyArray[i].ClearBet();
                GuyArray[i].UpdateLabels();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int betAmt = (int) betAmount.Value;
            int whichDog = (int)dogChoice.Value;
            bool PlaceBet;

            // assign name to bettor
            GuyBet.Name = whosBetting.Text;
            if (betAmt >= minBet)
            {
                PlaceBet = GuyBet.PlaceBet(betAmt, whichDog);
                if (PlaceBet)
                {
                    GuyBet.UpdateLabels();
                    BetPlaced = true;
                }
            }
            else
                MessageBox.Show(this, "The minimum bet is $" + minBet + "!!");

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            whosBetting.Text = "Joe";
            GuyBet = GuyArray[0];
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            whosBetting.Text = "Bob";
            GuyBet = GuyArray[1];
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            whosBetting.Text = "Al";
            GuyBet = GuyArray[2];
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                // start run function to move dogs
                GreyhoundArray[i].Run();
                if (!lockRace)
                {
                    if (GreyhoundArray[i].Run())
                    {
                        raceTimer.Stop();
                        int winner = i + 1;
                        MessageBox.Show("Congrats!  The winner is " + winner + "!!");
                        for (int x = 0; x < 3; x++)
                            GuyArray[x].Collect(winner);
                        // stop race
                        lockRace = true;
                        BetPlaced = false;
                        bettingParlor.Enabled = true;
                    }
                }
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            if (BetPlaced)
            {
                for (int i = 0; i <= 3; i++)
                {
                    GreyhoundArray[i].TakeStartingPosition();
                }
                // start timer
                raceTimer.Start();
                bettingParlor.Enabled = false;
                lockRace = false;
            }
            else
                MessageBox.Show("No bets were placed!");
        }
    }
}

