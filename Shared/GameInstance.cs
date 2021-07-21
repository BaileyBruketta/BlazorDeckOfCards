using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDeck.Shared
{
    public class GameInstance
    {
        public Deck deck;
        public List<Card> hand;
        public void newGame()
        {
            deck = new Deck();
            hand = new List<Card>();
        }
        public void draw()
        {
            Card newCard = deal_one_card();
            if (newCard != null)
            {
                hand.Add(newCard);
            }
        }

        public Card deal_one_card()
        {
            if (deck.cards.Count > 0)
            {
                Card draw = new Card(deck.cards[0].suite, deck.cards[0].value);
                deck.cards.RemoveAt(0);
                return draw;
            }
            else
            {
                return null;
            }
        }
    }
}
