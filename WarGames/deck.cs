using System;
using System.Linq;

namespace WarGames
{
    class Deck
    {
        public Card[] cards = new Card[52];

        public Deck()
        {

        }

        public int AddCard(Card pcard)
        {
            int number_of_cards = CardsInDeck();
            if (number_of_cards == 52)
            {
                Console.WriteLine("Already 52 cards in the deck! Cannot add any more cards to deck");
                return -1;
            }

            if (number_of_cards == 0)
            {
                cards[0] = pcard;
                return 0;
            }
            else
            {
                for (var i = number_of_cards; i > 0; i--)
                {
                    Card temp_card = cards[i -1];
                    cards[i] = temp_card;
                }
                cards[0] = pcard;
                return 0;
            }
        }
        
        /// <summary>
        /// Returns the top card of the player's deck object
        /// </summary>
        /// <returns>Top card of player's deck</returns>
        public Card CheckTopCard()
        {
            return cards[CardsInDeck() - 1];
        }

        //Returns the top card of the deck, then deletes it from this deck
        public Card GiveTopCard()
        {
            Card cardToGive = cards[CardsInDeck() - 1];
            cards[CardsInDeck() - 1] = null;
            return cardToGive;
        }

        public int CardsInDeck() // get cards in deck that are not null in the deck array
        {
            int result = cards.Count(s => s != null);
            return result;
        }

        public void ShowContents()
        {
            int number_of_cards = CardsInDeck();
            for (int _card_num = 0; _card_num < number_of_cards; _card_num++)
            {
                Card current_card = cards[_card_num];
                Console.Write(string.Format("[{0},{1}] ", current_card.rank, current_card.suit));
            }
            Console.WriteLine();
        }
        
        public void ShuffleDeck()  // copy bottom card to temp location
        {
            int number_of_cards = CardsInDeck();
            if (number_of_cards >= 2)
            {
                Card temp_card = cards[0];
                Random r = new Random();
                int index = r.Next(1, number_of_cards);
                cards[0] = cards[index];
                cards[index] = temp_card;
            }
        }


        public Card OutputCard(int card_index)
        {
            Card current_card = cards[card_index];
            return current_card;
        }
    }
}
