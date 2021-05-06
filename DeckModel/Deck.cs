using UdvDeck.CardModel;

namespace UdvDeck.DeckModel
{
    public abstract class Deck
    {
        public Card[] Cards { get; }
        public string Name { get; }

        protected Deck(string name, int cardsCount)
        {
            Name = name;
            Cards = new Card[cardsCount];
        }
    }
}