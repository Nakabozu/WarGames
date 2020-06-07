using System;

namespace WarGames
{
    class Card
    {
        //Description: A suit can be Hearts (H), Diamonds (D), Spades (S) or Clubs (C)
        private char suit;
        //Description: An integer from 1 to 13 representing they value on the card.
        //NOTE: 1 is an ACE, 11 is a Jack, 12 is a Queen, 13 is a King
        private int value;

        /// <summary>
        /// Action: Creation of a card with a suit and a value;
        /// </summary>
        /// <param name="st"></param>
        /// <param name="val"></param>
        public Card(char st, int val)
        {
            try
            {
                this.suit = st;
                this.value = val;
            }catch(Exception e)
            {
                Console.WriteLine("The suit or value entered was not valid");
                Console.Write(e);
            }
        }



        /// <summary>
        /// Action: take a look at the suit of the card
        /// </summary>
        /// <returns>A char of H, D, S or C representing the suit of the card</returns>
        public char getSuit()
        {
            return this.suit;
        }

        /// <summary>
        /// Action: Take a look at the value of the card;
        /// </summary>
        /// <returns>An integer from 1 to 13 representing the value of the card</returns>
        public int getValue()
        {
            return this.value;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
