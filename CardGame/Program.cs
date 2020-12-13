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
            IShuffleCards shuffleCards = new ShuffleCards();
            IDeck deck = new Deck(cardInitialization);
            IPlayCardLogic playCardLogic = new RemoveFrontPlayCardLogic();

            IGame game = new Game(deck, shuffleCards, playCardLogic);

            CardBase cardBase = game.PlayCard();
            game.ShuffleDeck();
            cardBase = game.PlayCard();
            game.Restart();
        }
    }
}
