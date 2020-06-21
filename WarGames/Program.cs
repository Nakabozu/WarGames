using System;
using Wargames;

namespace WarGames
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new deck
            Deck _deck = new Deck();

            // fill cards in deck
            foreach (char _suit in Card.Suit)
            {
                for (int _rank = 1; _rank < 14; _rank++)
                {
                    Card card = new Card(_suit, _rank);
                    _deck.AddCard(card);
                }
            }

            for (int iCard = 1; iCard < 52; iCard++)
            {
                _deck.ShuffleDeck();
            }


            player Player1 = new player("player 1");
            player Player2 = new player("player 2");

            for (int i = 0; i < 26; i++)
            {
                Card current_card = _deck.OutputCard(i);
                Player1.deck.AddCard(current_card);
            }

            for (int i = 26; i < 52; i++)
            {
                Card current_card = _deck.OutputCard(i);
                Player2.deck.AddCard(current_card);
            }

            int gameCounter = 0;
            do
            {
                gameCounter++;

                if(Player1.Play().Compare(Player2.Play()) == 1)
                {
                    Player1.deck.AddCard(Player2.deck.GiveTopCard());
                }
                else if(Player1.Play().Compare(Player2.Play()) == -1)
                {
                    Player2.deck.AddCard(Player1.deck.GiveTopCard());
                }
                else
                {
                    Player1.deck.AddCard(Player1.deck.GiveTopCard());
                    Player2.deck.AddCard(Player2.deck.GiveTopCard());
                }
            } while (gameCounter <= 100 && Player1.CanPlay() && Player2.CanPlay());


            /***********
             * RESULTS *
             ***********/
             
            Console.WriteLine(string.Format("(Player 1, {0})", Player1.Score()));
            Player1.deck.ShowContents();

            Console.WriteLine(string.Format("(Player 2, {0})", Player2.Score()));
            Player2.deck.ShowContents();

            if(Player1.Score() > Player2.Score())
            {
                Console.WriteLine(string.Format("Player 1 is the winner with a score of {0}", Player2.Score()));
            }
            else if (Player1.Score() < Player2.Score())
            {
                Console.WriteLine(string.Format("Player 2 is the winner with a score of {0}", Player2.Score()));
            }
            else
            {
                Console.WriteLine(string.Format("Both players tie with a score of {0}", Player2.Score()));
            }
        }
    }
}
