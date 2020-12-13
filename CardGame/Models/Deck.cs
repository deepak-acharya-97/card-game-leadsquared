﻿using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Models
{
    public class Deck
    {
        public IList<CardBase> Cards { get; private set; }

        public Deck(ICardInitialization cardInitialization)
        {
            Cards = cardInitialization.GetInitialDeckOfCards();
        }
    }
}