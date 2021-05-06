namespace UdvDeck.CardModel
{
    public class PokerCard : Card
    {
        public PokerCard(string value, PokerSuit suit) : base(value, suit)
        {
        }
    }

    public enum PokerSuit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}