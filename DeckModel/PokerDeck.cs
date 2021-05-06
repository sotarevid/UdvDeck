using System;
using UdvDeck.CardModel;

namespace UdvDeck.DeckModel
{
    public class PokerDeck : Deck
    {
        private readonly string[] _values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        
        public PokerDeck(string name) : base(name, 52)
        {
            SortDeck();
        }

        public void SortDeck()
        {
            var i = 0;
            foreach (PokerSuit suit in Enum.GetValues(typeof(PokerSuit)))
                foreach(var value in _values)
                    Cards[i++] = new PokerCard(value, suit);
        }
    }
}