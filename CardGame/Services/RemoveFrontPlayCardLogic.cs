using CardGame.Interfaces;
using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Services
{
    public class RemoveFrontPlayCardLogic : IPlayCardLogic
    {
        public CardBase PlayCard(List<CardBase> cards)
        {
            CardBase topOfDeck = cards.ElementAt(0);
            cards.RemoveAt(0);
            return topOfDeck;
        }
    }
}
