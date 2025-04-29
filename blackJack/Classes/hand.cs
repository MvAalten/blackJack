using System;
using System.Collections.Generic;
using System.Reflection;
using WindowsFormsApp1;
using static System.Formats.Asn1.AsnWriter;

public class Hand
{
    // What do i have in my hand
    private List<Card> cards;
    private int score;
    private bool winner;
    private bool loser;
    private bool blackjack;
    bool hasStood = false;

    public Hand()
    {
        cards = new List<Card>();
        score = 0;
        winner = false;
        loser = false;
        blackjack = false;
    }

    // Adds card to hand
    public void Hit(Card card)
    {
        cards.Add(card);
        CalculateScore();
    }
    public void Stand()
    {
        hasStood = true;
    }
    private void CalculateScore()
    {
        score = cards.Sum(card => card.Value);

        // if score ie above 11 change ace's to 1
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
