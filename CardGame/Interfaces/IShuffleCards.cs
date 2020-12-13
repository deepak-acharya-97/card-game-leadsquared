using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Interfaces
{
    public interface IShuffleCards
    {
        void ShuffledCards(List<CardBase> cards);
    }
}
