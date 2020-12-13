using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public abstract class CardBase
    {
        public CardBase() { }

        public CardBase(Suit suit)
        {
            Suit = suit;
        }

        public string Value { get; set; }
        public Suit Suit { get; set; }
    }
}
