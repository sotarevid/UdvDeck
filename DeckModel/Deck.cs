using UdvDeck.CardModel;

namespace UdvDeck.DeckModel
{
    public abstract class Deck
    {
        public Card[] Cards { get; }
        public string Name { get; }
        public int Length => Cards.Length;

        public Card this[int index]
        {
            get => Cards[index];
            set => Cards[index] = value;
        }
        
        protected Deck(string name, int cardsCount)
        {
            Name = name;
            Cards = new Card[cardsCount];
        }
    }
}