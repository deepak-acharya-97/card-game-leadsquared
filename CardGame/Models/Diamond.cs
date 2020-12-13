using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public class Diamond : CardBase
    {
        public Diamond(string value) : base(Suit.Diamond, value)
        {

        }
    }
}
