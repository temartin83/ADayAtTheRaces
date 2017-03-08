using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public class Guy
    {
        public string Name;
        public int Cash;
        public Bet MyBet;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            // set labels to bets and radio button labels to show cash
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has $" + Cash + " to wager.";
        }

        public void ClearBet()
        {
            // reset bets to zero
            MyBet = new Bet() { Amount = 0, Bettor = this };

        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // place bet on dog
            // return true if player can cover bet
            if (BetAmount <= Cash)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                return true;
            }
            else
                return false;


        }

        public void Collect(int Winner)
        {
            // pay out, clear bet, update labels
            Cash = Cash + MyBet.Payout(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}