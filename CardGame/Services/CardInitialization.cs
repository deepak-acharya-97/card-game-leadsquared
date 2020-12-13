using CardGame.Interfaces;
using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Services
{
    public class CardInitialization : ICardInitialization
    {
        public List<CardBase> GetInitialDeckOfCards()
        {
            List<CardBase> cards = new List<CardBase>();
            AddSpades(cards);
            AddClubs(cards);
            AddDiamonds(cards);
            AddHearts(cards);
            return cards;
        }

        private void AddHearts(List<CardBase> cards)
        {
            AddNumberics(Suit.Heart, cards);
            AddNonNumberics(Suit.Heart, cards);
        }

        private void AddNonNumberics(Suit heart, List<CardBase> cards)
        {
            switch (heart)
            {
                case Suit.Heart:
                    AddHeartNonNumerics(cards);
                    break;
                case Suit.Club:
                    AddClubNonNumerics(cards);
                    break;
                case Suit.Diamond:
                    AddDiamondNonNumerics(cards);
                    break;
                case Suit.Spade:
                    AddSpadeNonNumerics(cards);
                    break;
                default:
                    break;
            }
        }

        private void AddDiamondNonNumerics(List<CardBase> cards)
        {
            cards.Add(new Diamond("J"));
            cards.Add(new Diamond("K"));
            cards.Add(new Diamond("Q"));
            cards.Add(new Diamond("A"));
        }

        private void AddSpadeNonNumerics(List<CardBase> cards)
        {
            cards.Add(new Spade("J"));
            cards.Add(new Spade("K"));
            cards.Add(new Spade("Q"));
            cards.Add(new Spade("A"));
        }

        private void AddClubNonNumerics(List<CardBase> cards)
        {
            cards.Add(new Club("J"));
            cards.Add(new Club("K"));
            cards.Add(new Club("Q"));
            cards.Add(new Club("A"));
        }

        private void AddHeartNonNumerics(List<CardBase> cards)
        {
            cards.Add(new Heart("J"));
            cards.Add(new Heart("K"));
            cards.Add(new Heart("Q"));
            cards.Add(new Heart("A"));
        }

        private void AddNumberics(Suit heart, List<CardBase> cards)
        {
            switch (heart)
            {
                case Suit.Heart:
                    AddHeartNumerics(cards);
                    break;
                case Suit.Club:
                    AddClubNumerics(cards);
                    break;
                case Suit.Diamond:
                    AddDiamondNumerics(cards);
                    break;
                case Suit.Spade:
                    AddSpadeNumerics(cards);
                    break;
                default:
                    break;
            }
        }

        private void AddSpadeNumerics(List<CardBase> cards)
        {
            foreach (int number in Enumerable.Range(2, 8))
            {
                cards.Add(new Spade(number.ToString()));
            }
        }

        private void AddDiamondNumerics(List<CardBase> cards)
        {
            foreach (int number in Enumerable.Range(2, 8))
            {
                cards.Add(new Diamond(number.ToString()));
            }
        }

        private void AddClubNumerics(List<CardBase> cards)
        {
            foreach (int number in Enumerable.Range(2, 8))
            {
                cards.Add(new Club(number.ToString()));
            }
        }

        private void AddHeartNumerics(List<CardBase> cards)
        {
            foreach (int number in Enumerable.Range(2, 8))
            {
                cards.Add(new Heart(number.ToString()));
            }
        }

        private void AddDiamonds(List<CardBase> cards)
        {
            AddNumberics(Suit.Diamond, cards);
            AddNonNumberics(Suit.Diamond, cards);
        }

        private void AddClubs(List<CardBase> cards)
        {
            AddNumberics(Suit.Club, cards);
            AddNonNumberics(Suit.Club, cards);
        }

        private void AddSpades(List<CardBase> cards)
        {
            AddNumberics(Suit.Spade, cards);
            AddNonNumberics(Suit.Spade, cards);
        }
    }
}
