using System;
using System.Collections.Generic;
using WindowsFormsApp1;

namespace WinFormsBlackJackApp1.classes
{
    internal class Deck
    {
        private List<Card> cards;
        private static Random rng = new Random();

        public Deck()
        {
            cards = new List<Card>();
            CallOnDeck();
        }
        public void ShuffleCards()
        {
            Shuffle();
        }

        private void CallOnDeck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(Card.CreateCard(suit, faceValue));
                    //Console.WriteLine($"{faceValue} of {suit}"); 
                }
            }
        }

        public void Shuffle()
        {
            // as long as the amount of cards or i is larger then 0 it'll loop
            for (int i = cards.Count - 1; i > 0; i--)
            {
                //rng.Next creates a number between i (which is the amount of cards) and -1
                int j = rng.Next(i + 1);
                // the card count which counts up from 1 to 52  which is i is swapped with a random number called j
                (cards[i], cards[j]) = (cards[j], cards[i]);
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("No more cards in the deck.");

            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }
    }
}
