using System;
using System.Windows.Forms;
using WindowsFormsApp1;
using WinFormsBlackJackApp1.classes;

namespace blackJack
{
    public partial class Form1 : Form
    {
        Deck deck;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // New game
            deck = new Deck();

            richTextBox1.Clear();
            richTextBox1.AppendText("Game started!");
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
            // This button should deal one of my cards
            if (deck == null)
            {
                richTextBox1.AppendText("Start the game first!\n");
                return;
            }

            if (deck.CardsRemaining() > 0)
            {
                Card drawnCard = deck.DealCard();
                richTextBox1.AppendText($"Drawn card: {drawnCard.FaceValue} of {drawnCard.Suit}\n");
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

        private void label1_Click(object sender, EventArgs e)
        {
            // No logic needed here yet
        }
    }
}