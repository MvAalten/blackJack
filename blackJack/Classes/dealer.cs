using System;
using System.Collections.Generic;
using System.Numerics;
using WindowsFormsApp1;
using WindowsFormsApp1.classes;
using WinFormsBlackJackApp1.classes;

namespace WinFormsBlackJackApp1.classes
{
    internal class Dealer
    {
        public Hand hand { get; private set; }

        public Dealer()
        {
            hand = new Hand();
        }
        /**
         * Adds a card to your hand.
         */
        public void Hit(Card card)
        {
            hand.Hit(card);
        }
        /**
         * Sets Dealer's hand to stand.
         */
        public void Stand()
        {
            hand.Stand();
        }
        /**
         * Takes the top card from the deck.
         * 
         * Puts it in the dealer's hand.
         */
        public void DealCard(Deck deck)
        {
            Card card = deck.DealCard();
            Hit(card);
        }
        /**
         * Calls upon shuffle function in the deck class.
         */
        public void Shuffle(Deck deck)
        {
            deck.ShuffleCards();
        }

        /**
         * Work in progress
         * 
         * Steps written out here.
         * 
         * 
         * Checks if the dealer has a winner.
         * 
         * If the dealer has a score of 21 and has 2 cards, he has a blackjack.
         * 
         * If the dealer has a score of 21, he has won.
         * 
         * If the dealer has a score above 21, he has busted.
         */
        public void CheckWinner(List<Player> players)
        {

        }
    }
}
