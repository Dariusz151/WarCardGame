using System;
using System.Collections.Generic;
using System.Text;

namespace WarCardGame
{
    public class Deck
    {
        private Random _random = new Random();
        private Stack<Card> _deck = new Stack<Card>();
        //private readonly string[] _suits = { "Spades", "Clubs", "Hearts", "Diamnods" };
        

        public void BuildDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int value = 2; value < 16; value++)
                {
                    Card card = new Card(value, suit);
                    this._deck.Push(card);
                }
            }
        }

    }

    public enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamnods
    }

}
