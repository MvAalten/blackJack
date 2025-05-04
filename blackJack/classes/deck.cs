using System;
using System.Collections.Generic;
using WindowsFormsApp1;

namespace WinFormsBlackJackApp1.classes
{
    internal class Deck
    {
        private List<Card> cards;
        private static Random rng = new Random();
        //private bool IsClosed = false;

        public Deck()
        {
            // New list of cards
            cards = new List<Card>();
            // Initializes the deck
            InitializeDeck();
        }
        /**
         * For every suit loop
         *  For every FaceValue loop
         *      You get a new card
         */
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

        /**
         * Getter for shuffled cards
         */
        public void ShuffleCards()
        {
            Shuffle();
        }
        /**
         * If there are cards left in the deck
         *      Console.WriteLine("No cards left")
         *      
         * If there are cards left in the deck 
         * 
         * Deal the first card
         * 
         * Remove the card that you just dealt from the deck
         */
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
        /**
        * Shuffles the deck
        * 
        * For every card in the deck
        *  Get a random number between 0 and the current card count
        *  Swap the current card with the random card
        */
        private void Shuffle()
        {
            for (int cardCount = 0; cardCount < 52; cardCount++)
            {
                int R = rng.Next(cardCount);
                (cards[cardCount], cards[R]) = (cards[R], cards[cardCount]);
            }
        }

        public int CardsRemaining() // debugging
        {
            return cards.Count;
        }
    }
}
