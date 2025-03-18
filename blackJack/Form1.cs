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
            //string hello = Console.ReadLine();
            //Console.WriteLine(hello);
  
            // Creates a deck
            List<Cards> deck = Cards.CreateDeck();


            // Shuffles all my cards
            Cards.Shuffle(deck);


            // Shows my cards in the console
            foreach (var card in deck)
            {
                Console.WriteLine(card); 
            }
        }
    }
}
