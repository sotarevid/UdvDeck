using System.Collections.Generic;
using System.Linq;
using UdvDeck.DeckModel;
using UdvDeck.Shuffler;

namespace UdvDeck
{
    public class DeckController
    {
        private Dictionary<string, Deck> _decks = new Dictionary<string, Deck>();
        private IDeckShuffler _shuffler = new FisherYatesShuffler();
        
        public void CreateDeck(string name)
        {
            if (!_decks.ContainsKey(name))
                _decks[name] = new PokerDeck(name);
        }

        public void DeleteDeck(string name)
        {
            if (_decks.ContainsKey(name))
                _decks.Remove(name);
        }

        public List<string> GetDeckList()
        {
            return _decks.Keys.ToList();
        }

        public void ShuffleDeck(string name)
        {
            _shuffler.Shuffle(_decks[name]);
        }
    }
}