
using blackJack.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace blackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Makes new deck
            Deck deck = new Deck();

            Console.WriteLine("Shuffling deck...");
            deck.ShuffleCards();

            while (true)
            {
                Console.Write("Type 'pull' to draw a card or 'exit' to quit: ");
                // ToLower makes everything lowercase and trim prevents crashes from empty input
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "pull")
                {
                    if (deck.CardsRemaining() > 0)
                    {
                        Card drawnCard = deck.DealCard();
                        Console.WriteLine($"Drawn card: {drawnCard.FaceValue} of {drawnCard.Suit}");
                    }
                    else
                    {
                        Console.WriteLine("No more cards left in the deck!");
                    }
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command! Type 'pull' or 'exit'.");
                }

            }
        }
    }
}
