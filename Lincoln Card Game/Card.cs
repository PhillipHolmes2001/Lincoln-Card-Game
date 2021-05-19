using System;


namespace Lincoln_Card_Game
{
	public class Card
	{

		private string value;
		private string suit;

		public Card(string cardValue, string cardSuit)
		{
			value = cardValue;
			suit = cardSuit;
		}

        public override string ToString()
        {
			return value + " of " + suit;
        }
    }
}