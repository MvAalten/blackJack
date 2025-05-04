using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1;

public class Hand
{
    // What do I have in my hand
    private List<Card> cards;
    private int score;
    private bool winner;
    private bool loser;
    private bool blackjack;
    private bool tie;
    private bool hasStood = false;

    public Hand()
    {
        cards = new List<Card>();
        score = 0;
        winner = false;
        loser = false;
        blackjack = false;
        tie = false;
    }

    /**
     * Adds a card to the hand
     * 
     * Checks the score
     * 
     * Checks for win, bust or blackjack.
     * 
     * Blackjack isn't possible in this case because the player has 2 cards before he hits so 3 after a hit which makes it impossible.
     */
    public void Hit(Card card)
    {
        cards.Add(card);
        CalculateScore();
    }

    public void Stand()
    {
        hasStood = true;
    }
    /**
     * Total scare equals the total value of the cards in the hand
     * 
     * For each card in the hand, add the value of the card to the total score
     * 
     * For each ace in the hand valued at 11 continue
     * 
     * If your score is above 21, change the ace to 1
     * 
     * If you have 2 cards and have 21 you have hit a blackjack
     * 
     * If score is bigger than 21 you have busted
     * 
     * If your score is 21 you have won
     */
    private void CalculateScore()
    {
        score = cards.Sum(card => card.Value);

        // Loop through each card in the hand
        // BUT only select cards that are:
        // 1. An Ace (FaceValue == ACE)
        // 2. This ace card is currently at a value of 11
        foreach (Card card in cards.Where(c => c.FaceValue == FaceValues.ACE && c.Value == 11))
        {
            if (score > 21)
            {
                card.AceChangeTo10();
                score -= 10;
            }
        }

        if (score == 21 && cards.Count == 2)
            blackjack = true;
        else if (score > 21)
            loser = true;
        else if (score == 21)
            winner = true;
    }
}
