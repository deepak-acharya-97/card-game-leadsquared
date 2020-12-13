using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public class Deck : IDeck
    {
        public List<CardBase> Cards { get; }

        public Deck(ICardInitialization cardInitialization)
        {
            Cards = cardInitialization.GetInitialDeckOfCards();
        }

    }
}
