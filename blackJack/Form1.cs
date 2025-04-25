using System;
using System.Windows.Forms;
using WinFormsBlackJackApp1.classes;
using WindowsFormsApp1;

namespace blackJack
{
    public partial class Form1 : Form
    {
        Deck deck;
        Hand playerHand; // <-- New: player's hand

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // New game
            deck = new Deck();
            playerHand = new Hand(); // <-- New: initialize hand

            richTextBox1.Clear();
            richTextBox1.AppendText("Game started!\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Shuffle button
            if (deck == null)
            {
                richTextBox1.AppendText("Start the game first!\n");
                return;
            }

            deck.ShuffleCards();
            richTextBox1.AppendText("Deck shuffled!\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Deal a card to the player
            if (deck == null || playerHand == null)
            {
                richTextBox1.AppendText("Start the game first!\n");
                return;
            }

            if (deck.CardsRemaining() > 0)
            {
                Card drawnCard = deck.DealCard();
                playerHand.Hit(drawnCard); // <-- New: add card to hand
                richTextBox1.AppendText($"You drew: {drawnCard.FaceValue} of {drawnCard.Suit}\n");
            }
            else
            {
                richTextBox1.AppendText("No more cards left in the deck!\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // auto scroll
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
