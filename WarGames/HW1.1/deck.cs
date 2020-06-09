using System;
using System.Collections.Generic;
using System.Text;

namespace HW1._1
{
    class Deck
    {
        public static Card[] deck = new Card[52];
        public static void FillDeck()
        {
            int index = 0;
            foreach (string _suit in Card.Suit)
            {
                for(int _rank = 1; _rank <14; _rank++)
                {
                    Card card = new Card(_rank, _suit);
                    deck[index] = card;
                    index++;
                }
            }
            return Shuffle(Card);
        }
    }
}
