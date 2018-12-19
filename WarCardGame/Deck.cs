using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarCardGame
{
    public class Deck
    {
        private readonly Random _random = new Random();
        private Stack<Card> _deck = new Stack<Card>();

        /// <summary>
        /// Builds a new deck of 52 cards.
        /// </summary>
        public void BuildDeck()
        {
            if (_deck != null && _deck.Count() != 52)
            {
                _deck.Clear();
            }
            else
            {
                Console.WriteLine("A deck with 52 cards already exists.");
                return;
            }

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int value = 2; value < 16; value++)
                {
                    Card card = new Card(value, suit);
                    _deck.Push(card);
                }
            }
        }

        /// <summary>
        /// Shuffle the deck.
        /// </summary>
        public void Shuffle()
        {
            _deck = new Stack<Card>(_deck.OrderBy(x => _random.Next()));
        }

        /// <summary>
        /// Deal out a card.
        /// </summary>
        /// <returns></returns>
        public Card DealCard()
        {
            return _deck.Pop();
        }
    }

    

}
