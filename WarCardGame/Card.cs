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
        private Dictionary<int, Figures> _figureMap = new Dictionary<int, Figures>()
        {
            { 11, Figures.Jack },
            { 12, Figures.Queen },
            { 13, Figures.King },
            { 14, Figures.Ace }
        };

        private Figures _fValue;
        private int _value;
        public Suit Suit { get; set; }

        public dynamic Value
        {
            get
            {
                if (_value != 0)
                    return _value;
                else
                    return _fValue;
            }
            set
            {
                if (value > 10)
                {
                    _fValue = _figureMap[value];
                    _value = 0;
                }
                else
                {
                    _value = value;
                }
            }
        }
        
        public Card(int value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"Card: {this.Value.ToString()} Suit: {this.Suit.ToString()}.";
        }
    }
}
