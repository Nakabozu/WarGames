using System;
using System.Net.Security;

namespace WarGames
{
    




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Card c1 = new Card('H', 1);
            Card c2 = new Card('D', 3);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c2.Compare(c1));
        }
    }
}
