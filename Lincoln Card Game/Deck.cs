using System;


namespace Lincoln_Card_Game
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private Random ranInt;

        public Deck()
        {
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                                "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            deck = new Card[52];
            currentCard = 0;
            ranInt = new Random();
            for (int i = 0; i<deck.Length; i++)
                deck[i] = new Card(values[i % 11], suits[i / 13]);
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranInt.Next(52);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        
        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }
    }
}
