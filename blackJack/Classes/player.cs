using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes
{
    class Player
    {
        bool hasStood = false;
        List<Card> cards = new List<Card>();
        public void Hit(Card card)
        {
            if (hasStood)
            {
                return;
            }
            cards.Add(card);
        }

        public void Stand()
        {
            hasStood = true;
        }
    }
}