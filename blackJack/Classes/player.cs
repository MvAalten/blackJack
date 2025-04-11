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

        public Player()
        {
            hands = new List<Hand>();
            hands.Add(new Hand());
        }

        public void AddCard(Card card)
        {
            hands[0].Hit(card);
        }

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

        public void Stand()
        {
            hasStood = true;
        }

        public void DoubleDown(Card card)
        {
            cards.Add(card);
            
            Stand();
        }

    }
}
