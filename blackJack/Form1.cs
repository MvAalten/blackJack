using WindowsFormsApp1;
using WinFormsBlackJackApp1.classes;

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
                // ToLower makes everything lowercase and trim makes it so that the program doesnst crash if somebody
                // inputs ""
                string input = Console.ReadLine()?.Trim().ToLower();

             
                if (input == "exit")
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
