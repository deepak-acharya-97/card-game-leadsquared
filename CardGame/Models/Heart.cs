using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public class Heart : CardBase
    {
        public Heart(string value) : base(Suit.Heart, value)
        {

        }
    }
}
