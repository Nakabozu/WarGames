using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarGames
{
    class Deck
    {
        public Card[] deck = new Card[52];

        public Deck()
        {
            
           
        }

        public void AddCard(Card pcard)
        {
            int number_of_cards = CardsInDeck();
            if (number_of_cards == 52)
            {
                Console.WriteLine("Already 52 cards in the deck! Cannot add any more cards to deck");
                return;
            }

            if (number_of_cards == 0)
            {
                deck[0] = pcard;
            }
            else
            {
                for (var i = number_of_cards; i > 0; i--)
                {
                    Card temp_card = deck[i -1];
                    deck[(i)] = temp_card;
                }
                deck[0] = pcard;
            }
        }

        public int CardsInDeck() // get cards in deck that are not null in the deck array
        {
            int result = deck.Count(s => s != null);
            return result;
        }

        public void ShowContents()
        {
            int number_of_cards = CardsInDeck();
            for (int _card_num = 0; _card_num < number_of_cards; _card_num++)
            {
                Card current_card = deck[_card_num];
                Console.WriteLine(string.Format("Suit: {0} Rank: {1}", current_card.suit, current_card.rank));
            }
        }
        
        public void ShuffleDeck()  // copy bottom card to temp location
        {
            int number_of_cards = CardsInDeck();
            if (number_of_cards >= 2)
            {
                Card temp_card = deck[0];
                Random r = new Random();
                int index = r.Next(1, number_of_cards);
                deck[0] = deck[index];
                deck[index] = temp_card;
            }
        }

        public Card OutputCard(int card_index)
        {
            Card current_card = deck[card_index];
            return current_card;
        }
    }
}
