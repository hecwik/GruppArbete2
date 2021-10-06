using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;

        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        // idx klassindex
        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => cards.Length;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < nrOfCards; i++)
            {
                sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            var rnd = new Random(); //rnd is now a random generator - see .NET documentation

            //YOUR CODE
            //to shuffle the deck.
            //Hint: pick two cards in the deck randomly and swap them. Do this 1000 times
        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;

            //YOUR CODE
            //to initialize a fresh deck of cards
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards()
        {



            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards
        }
    }
}
// - Randomly generate 3 cards using the using the default constructor (the one without
// parameters). Print them out
// - Initiate a fresh deck of cards with 52 Cards. Print out the deck
// - Shuffle the deck. Print out the shuffled deck