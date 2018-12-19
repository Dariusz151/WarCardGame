using System;
using System.Collections.Generic;
using System.Text;

namespace WarCardGame
{
    public class Card
    {
        public int Value { get; set; }
        public string Suit { get; set; }

        public Card(int value, string suit)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
