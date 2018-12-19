using System;
using System.Collections.Generic;
using System.Text;

namespace WarCardGame
{
    /// <summary>
    /// Initializes a new instance of the card class.
    /// </summary>
    public class Card
    {
        public int Value { get; set; }
        public Suit Suit { get; set; }

        public Card(int value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"Card: {this.Value} Suit: {this.Suit.ToString()}.";
        }
    }
}
