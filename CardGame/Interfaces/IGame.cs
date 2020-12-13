using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Interfaces
{
    public interface IGame
    {
        CardBase PlayCard();
        void ShuffleDeck();
        void Restart();
    }
}
