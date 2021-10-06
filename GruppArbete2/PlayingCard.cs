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
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
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
                //YOUR CODE
                //to return "Face" or "Value"
                //Use switch expression
            }
        }
        public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} {FaceOrValue} card"; // add FaceOrValue

        /// <summary>
        /// Constructor that generates a random card
        /// </summary>
        public PlayingCard()
        {

            Random rnd1 = new Random();
            Random rnd2 = new Random();

            rnd1.Next((int)PlayingCardColor.Clubs, (int)PlayingCardColor.Spades);
            rnd2.Next((int)PlayingCardValue.Two, (int)PlayingCardValue.Ace);




            //YOUR CODE
            // write a constructor that generates a random card.
            // I.e., PlayingCard card1 = new PlayingCard(); generates a random card.
        }
    }
}