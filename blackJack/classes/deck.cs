using System;
using System.Collections.Generic;
using WindowsFormsApp1;

namespace WinFormsBlackJackApp1.classes
{
    internal class Deck
    {
        private List<Card> cards;
        private static Random rng = new Random();
        private bool IsClosed = false;

        public Deck()
        {
            // New list of cards
            cards = new List<Card>();
            // Initializes the deck
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            // For every suit loop
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                // In every suit loop loop for every FaceValue
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                     cards.Add(new Card(suit, faceValue));
                }
            }
        }

        public void ShuffleCards()
        {
            Shuffle();
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("No cards left");

            }
            // Goes into my public class Card in my card.cs file creates a new variable (dealtCard) and fills this with the first
            // instance of the cards array
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }

        private void Shuffle()
        {
            for (int cardCount = cards.Count - 1; cardCount > 0; cardCount--)
            {
                int R = rng.Next(cardCount + 1);
                (cards[cardCount], cards[R]) = (cards[R], cards[cardCount]);
            }
        }

        public int CardsRemaining() // debugging
        {
            return cards.Count;
        }
    }
}
