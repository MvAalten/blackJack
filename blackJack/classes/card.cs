using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Suits
    {
        // All of me card suits
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValues
    {
        // Values of my cards
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    public class Card
    {
        public Suits Suit { get; }
        public FaceValues FaceValue { get; } 
        public int Value { get; private set; }
        public bool IsClosed { get; set; } = true;

        public Card(Suits suit, FaceValues faceValue)
        {
            Suit = suit; 
            FaceValue = faceValue;

            switch (faceValue)
            {
                case FaceValues.ACE:
                    Value = 11;
                    break;
                case FaceValues.TEN:
                case FaceValues.JACK:
                case FaceValues.QUEEN:
                case FaceValues.KING:
                    Value = 10;
                    break;
                default:
                    Value = (int)faceValue;
                    break;
            }
        }

        public string CardOutput()
        {
            return $"{FaceValue} of {Suit}";
        }
    }

}
