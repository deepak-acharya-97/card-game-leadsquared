using CardGame.Interfaces;
using CardGame.Models;
using CardGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ICardInitialization cardInitialization = new CardInitialization();
            List<CardBase> cards = cardInitialization.GetInitialDeckOfCards();
            IShuffleCards shuffleCards = new ShuffleCards();
            List<CardBase> shuffledCards =  shuffleCards.GetShuffledCards(cards);
            //List<CardBase> shuffledCards = cards.OrderBy(card => Guid.NewGuid()).ToList();
        }
    }
}
