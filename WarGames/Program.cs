using System;
using System.Net.Security;

namespace WarGames
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new deck
            Deck  _deck = new Deck();

            //list cards in deck
            Console.WriteLine( _deck.CardsInDeck());

            // fill cards in deck
            foreach (char _suit in Card.Suit)
            {
                for (int _rank = 1; _rank < 14; _rank++)
                {
                    Card card = new Card(_suit, _rank);
                     _deck.AddCard(card);
                }
            }

            // list cards in deck
            Console.WriteLine("Cards in _deck");
            Console.WriteLine(_deck.CardsInDeck());


            for (int iCard = 1; iCard < 52; iCard++)
            {
                _deck.ShuffleDeck();
            }

             // show contents before shuffle
            _deck.ShowContents();

            Deck deck1 = new Deck();
            Deck deck2 = new Deck();

            for (int i = 0; i < 26; i++)
            {
                Card current_card =  _deck.OutputCard(i);
                deck1.AddCard(current_card);
            }

            Console.WriteLine("Cards in deck1");
            deck1.ShowContents();

            for (int i = 26; i < 52; i++)
            {
                Card current_card =  _deck.OutputCard(i);
                deck2.AddCard(current_card);
            }

            Console.WriteLine("Cards in deck2");
            deck2.ShowContents();

            // add card from top of 2nd deck to bottom of first deck
            deck1.AddCard(deck2.OutputCard(25));

            Console.WriteLine("Cards in deck1 now");
            deck1.ShowContents();



        }
    }
}
