using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    public enum PlayingCardColor
    {
        Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
    }
    public enum PlayingCardValue
    {
        Two = 2, Three, Four, Five, 
        Six, Seven, Eight, Nine, Ten,
        Knight, Queen, King, Ace                // Poker Value order
    }
    public class PlayingCard
    {
        public PlayingCardColor Color { get; init; }
        public PlayingCardValue Value { get; init; }

        public string BlackOrRed
        {
            get
            {
                if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
                    return "Black";

                return "Red";
            }
        }

        /// <summary>
        /// Returns "Face" for Ace,Knight, Queen, King. Otherwise it returns "Value".
        /// 
        /// </summary>
        string FaceOrValue
        {
            get
            {
                // use switch expression that returns Face or Value
                // depending on if the card is a suit or a numbered card
                string sRet = Value switch
                {
                    PlayingCardValue.Knight 
                    or PlayingCardValue.Queen 
                    or PlayingCardValue.King 
                    or PlayingCardValue.Ace => "Face",

                    _ => "Value"
                };
                // return the string value determined by the switch expression
                return sRet;
            }
        }
        public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} {FaceOrValue} card";

        /// <summary>
        /// Constructor that generates a random card
        /// </summary>
        public PlayingCard()
        {
            Random rnd = new Random();   

            Color = (PlayingCardColor)rnd.Next((int)PlayingCardColor.Clubs, (int)PlayingCardColor.Spades + 1);
            Value = (PlayingCardValue)rnd.Next((int)PlayingCardValue.Two, (int)PlayingCardValue.Ace + 1);
        }
    }
}