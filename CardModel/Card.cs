using System;

namespace UdvDeck.CardModel
{
    public abstract class Card
    {
        public string Value { get; }
        public Enum Suit { get; }

        protected Card(string value, Enum suit)
        {
            Value = value;
            Suit = suit;
        }
        
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}