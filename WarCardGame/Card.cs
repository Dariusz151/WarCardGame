using System;
using System.Collections.Generic;
using System.Text;

namespace WarCardGame
{
    public class Card
    {
        public int Value { get; set; }
        public Suit Suit { get; set; }

        public Card(int value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }
    }
}
