using CardGame.Interfaces;
using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CardGame
{
    public class Game : IGame
    {
        private readonly IDeck _deck;
        private List<CardBase> _cards;
        private readonly IShuffleCards _shuffleCards;
        private readonly IPlayCardLogic _playCardLogic;

        public Game(IDeck deck, IShuffleCards shuffleCards, IPlayCardLogic playCardLogic)
        {
            _deck = deck;
            _cards = deck.Cards.ToList();
            _shuffleCards = shuffleCards;
            _playCardLogic = playCardLogic;
        }

        public CardBase PlayCard()
        {
            return _playCardLogic.PlayCard(_cards);
        }

        public void Restart()
        {
            _cards = _deck.Cards;
        }

        public void ShuffleDeck()
        {
            _cards = _shuffleCards.GetShuffledCards(_cards);
        }
    }
}
