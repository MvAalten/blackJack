using System;
using System.Collections.Generic;
using WindowsFormsApp1;

public class Hand
{
    // What do i have in my hand
    private List<Card> cards;
    private int score;
    private bool winner;
    private bool loser;
    private bool blackjack;
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
    }
}
