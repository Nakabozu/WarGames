using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HW1._1
{
    class Card
    {
        public int _rank;
        public static string[] Suit = new string[] {"S", "H", "D", "C"};
        public string _suit;
        public Card(int rank, string suit)
        {
            _rank = rank;
            _suit = suit;

        }
                public int Compare(Card c)
        {
            int otherCardValue = c._rank;
            if (this._rank < otherCardValue)
            {
                return -1;
            }
            else if (this._rank > otherCardValue)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
