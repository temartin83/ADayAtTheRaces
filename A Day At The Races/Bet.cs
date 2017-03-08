using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            // return string that says who placed what bet
            // or "name hasn't placed a bet"
            string betHolder;
            if (Amount == 0)
                betHolder = Bettor.Name + " hasn't placed bet yet!";
            else
                betHolder = Bettor.Name + " bets $" + Amount + " on dog " + Dog;
            return betHolder;
        }

        public int Payout(int Winner)
        {
            // pay out winnings or collect
            if (Winner == Dog)
                return Amount;
            else
                return -Amount;
        }
    }
}
