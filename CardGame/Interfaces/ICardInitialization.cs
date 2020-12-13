using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Interfaces
{
    public interface ICardInitialization
    {
        List<CardBase> GetInitialDeckOfCards();
    }
}
