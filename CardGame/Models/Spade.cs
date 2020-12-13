using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public class Spade : CardBase
    {
        public Spade(string value) : base(Suit.Spade, value)
        {

        }
    }
}
