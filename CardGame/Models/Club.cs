using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public class Club : CardBase
    {
        public Club(string value) : base(Suit.Club, value)
        {

        }
    }
}
