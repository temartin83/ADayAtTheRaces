using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomizer;

        private int AddLoc;

        public bool Run()
        {
            // Move forward either 1, 2, 3, or 4 spaces at random
            // Update position of picturebox as such:
            // MyPictureBox.Left = StartingPosition + Location;
            // Return true if I won
            Location = Randomizer.Next(1, 4);
            AddLoc += Location;
            MyPictureBox.Left = StartingPosition + AddLoc;
            if (MyPictureBox.Left >= RacetrackLength)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            // Reset location to 0 and my PictureBox to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;
            AddLoc = 0;
        }
    }
}
