using System;
using UdvDeck.DeckModel;

namespace UdvDeck.Shuffler
{
    public class FisherYatesShuffler : IDeckShuffler
    {
        private static readonly Random Random = new Random();
        public void Shuffle(Deck deck)
        {
            var n = deck.Length;
            while (n > 1)
            {
                var k = Random.Next(n--);
                var tmp = deck[n];
                deck[n] = deck[k];
                deck[k] = tmp;
            }
        }
    }
}