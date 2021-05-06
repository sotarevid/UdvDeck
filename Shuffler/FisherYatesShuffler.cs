using System;
using UdvDeck.DeckModel;

namespace UdvDeck.Shuffler
{
    public class FisherYatesShuffler : IDeckShuffler
    {
        private static readonly Random Random = new Random();
        public void Shuffle(Deck deck)
        {
            for (var i = deck.Cards.Length - 1; i < 0; --i)
            {
                var j = Random.Next(i + 1);
                var tmp = deck[i];
                deck[i] = deck[j];
                deck[j] = tmp;
            }
        }
    }
}