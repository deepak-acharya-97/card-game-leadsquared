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

        public Game(IDeck deck, IShuffleCards shuffleCards)
        {
            _deck = deck;
            _cards = deck.Cards;
            _shuffleCards = shuffleCards;
        }

        public CardBase PlayCard()
        {
            CardBase topOfDeck = null;
            try
            {
                topOfDeck = _cards.ElementAt(0);
                _cards.RemoveAt(0);
            }
            catch(Exception ex)
            {

            }
            return topOfDeck;
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
