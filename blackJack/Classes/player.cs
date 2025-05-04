using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes
{
    class Player
    {
        private bool hasStood = false;
        private List<Card> cards = new List<Card>();
        private List<Hand> hands;

        /**
         * Creates a single player with a hand
         */
        public Player()
        {
            hands = new List<Hand>();
            hands.Add(new Hand());
        }
        /**
         * Adds a card to player 0's hand
         */
        public void AddCard(Card card)
        {
            hands[0].Hit(card);
        }
        /**
         * If player has stood, do nothing
         * 
         * Add a card to the hand
         * 
         * If the player has a hand, add the card to the hand 
         */
        public void Hit(Card card)
        {
            if (hasStood)
            {
                return;
            }
            cards.Add(card);
            if (hands.Count > 0)
            {
                hands[0].Hit(card);
            }
        }
        /**
         * Player stands
         */
        public void Stand()
        {
            hasStood = true;
        }
        /**
         * Player Doubles down
         * 
         * Player receives 1 more card
         * 
         * Player automatically stands
         */
        public void DoubleDown(Card card)
        {
            cards.Add(card);
            Stand();
        }
    }
}
