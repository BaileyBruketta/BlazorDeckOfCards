using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace BlazorDeck.Shared
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public Deck()
        {
            newDeck();
        }

        public void newDeck()
        {
            //Make one card of each suite for each value
            for(int values = 0; values < 13; values++)
            {
                cards.Add(new Card(0, values));
                cards.Add(new Card(1, values));
                cards.Add(new Card(2, values));
                cards.Add(new Card(3, values));
            }
        }

        public void shuffle()
        {
            List<Card> newDeck = new List<Card>();
            Random rand = new Random();
            while(cards.Count > 0)
            {
                int randInt = rand.Next(0, cards.Count - 1);
                Card newCard = new Card(cards[randInt].suite, cards[randInt].value);
                newDeck.Add(newCard);
                cards.RemoveAt(randInt);
            }
            cards = newDeck;
        }
    }
}
