using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDeck.Shared
{
    public class Card
    {
        public int suite;
        public int value;
        public Card(int suiteNum, int valueNum)
        {
            suite = suiteNum;
            value = valueNum;
        }

        public String getSuite()
        {
            String suitestring = "";
            switch (suite)
            {
                case 0: suitestring = "Diamonds"; break;
                case 1: suitestring = "Hearts"; break;
                case 2: suitestring = "Clubs"; break;
                case 3: suitestring = "Spades"; break;
            }
            return suitestring;
        }

        public String getValue()
        {
            String valuetring = "";
            switch (value)
            {
                case 0: valuetring = "Ace"; break;
                case 1: valuetring = "Two"; break;
                case 2: valuetring = "Three"; break;
                case 3: valuetring = "Four"; break;
                case 4: valuetring = "Five"; break;
                case 5: valuetring = "Six"; break;
                case 6: valuetring = "Seven"; break;
                case 7: valuetring = "Eight"; break;
                case 8: valuetring = "Nine"; break;
                case 9: valuetring = "Ten"; break;
                case 10: valuetring = "Jack"; break;
                case 11: valuetring = "Queen"; break;
                case 12: valuetring = "King"; break;
            }
            return valuetring;
        }
    }
}
