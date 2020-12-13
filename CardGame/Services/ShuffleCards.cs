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
        public List<CardBase> GetShuffledCards(List<CardBase> cards)
        {
            return cards.OrderBy(card => Guid.NewGuid()).ToList();
        }
    }
}
