using System;
using System.Collections.Generic;

namespace Lincoln_Card_Game
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Card> playerDeck = new List<Card>();
            List<Card> compDeck = new List<Card>();
            Deck orgDeck = new Deck();
            orgDeck.Shuffle();
            for (int k = 0; k < 10; k++)
            {
                // Console.Write("{0,-19}", orgDeck.DealCard());
                playerDeck.Add(orgDeck.DealCard());
                Console.Write(playerDeck[k] + ", ");
            }
            for (int l = 0; l < 10; l++)
            {
                compDeck.Add(orgDeck.DealCard());
            }
            Console.ReadLine();
        }
    }
}
