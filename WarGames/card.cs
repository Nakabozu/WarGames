using System;

namespace WarGames
{
    class Card
    {
        public char suit { get; } // valid suits are (H, S, C, D) [H=Hearts, S=Spades, C=Clubs, D=Diamonds]

        public static char[] Suit = new char[] { 'S', 'H', 'D', 'C' };

        public int rank { get; } //NOTE: 1 is ACE, 11 is Jack, 12 is Queen, 13 is King

        public Card(char st, int val) // Create a card with a suit and a value;
        {
            try
            {
                if(this.Check(st))
                {
                     this.suit = st;
                }
                else
                {
                    Exception e = new ArgumentException();
                    throw e;
                }

                if (this.Check(val))
                {
                    this.rank = val;
                }
                else
                {
                    Exception e = new ArgumentOutOfRangeException();
                    throw e;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The suit or value entered was not valid");
                Console.Write(e);
            }
        }

        public int Compare(Card c)
        {
            int otherCardValue = c.rank;
            if(this.rank == otherCardValue)
            {
                return 0;
            }
            else if ((this.rank > otherCardValue || this.rank == 1) && otherCardValue != 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private bool Check(int val) //Checking if the value is valid
        {
            if (val < 14 && val > 0)
            {
                return true;
            }
            Console.WriteLine(val + " is not a valid value between 0 and 14 (exclusive).");
            return false;
        }

        private bool Check(char st) //Checking if the suit is valid
        {
            if (st == 'H' || st == 'D' || st == 'S' || st == 'C')
            {
                return true;
            }
            Console.WriteLine(st + " is not a valid suit of H, D, S or C.");
            return false;
        }

        public override string ToString()
        {
            return string.Format("Suit: {0}\tRank: {1}", suit, rank);
        }
    }
}
