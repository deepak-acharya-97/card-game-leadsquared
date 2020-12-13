using CardGame.Interfaces;
using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Services
{
    public class ShuffleCards : IShuffleCards
    {
        public void ShuffledCards(List<CardBase> cards)
        {
            cards = cards.OrderBy(card => Guid.NewGuid()).ToList();
        }
    }
}
