using System;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;

        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

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

            for (int i = 0; i < Count; i++)
            {
                // if element at cards[i] is NOT null, invoke cards[i].ToString() method
                if (cards[i] != null)
                    sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle(DeckOfCards myDeck)
        {
            try
            {
                Console.WriteLine($"\nA shuffled deck with {myDeck.Count} cards:\n");
                Console.WriteLine(myDeck);
                var rnd1 = new Random(); //rnd is now a random generator - see .NET documentation
                var tmp = new PlayingCard();

                int count = 0;

                // swap 1000 times
                for (int i = 0; i < 1000; i++)
                {
                    for (int unsortedStart = 0; unsortedStart <= Count - 1; unsortedStart++)
                    {
                        // swap cards in the array with a card at a random index using Random object 
                        tmp = cards[unsortedStart];
                        int index = rnd1.Next(0, unsortedStart + 1);
                        cards[unsortedStart] = cards[index];
                        cards[index] = tmp;
                    }
                    count++;
                }
            } 
            catch(Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;

            // nested for loop that stores PlayingCard objects in the PlayingCard[] cards array
            // using the enum values of the colors and values of the cards

            // when color is clubs, create cards one, two three.. etc of current color up to ace
            // then repeat with the next color up until spades
            // lowest card (first created one) is two of clubs, and the highest card is ace of spades (last created one)
            for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++)
            {
                for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++)
                {
                    // set members values to the enum objects' current value
                    cards[cardNr] = new PlayingCard { Color = color, Value = value };
                    // use increment on cardNr counter
                    cardNr++;
                }
            }
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            // replace value of element at cards[0] with null (draw it from the deck)
            PlayingCard cardDrawn = cards[0];
            cards[0] = null;

            // Below code shifts the deck to put cards[1] in the place of cards[0]
            // and move along the other cards in the deck by one index position towards the top
            // 

            int length = Count; // assign the value of Count to a new int variable that can be manipulated,
                                // is used for recounting the number of cards left after drawing cards from the deck

            // nested for-loop for shifting array and avoiding duplicate cards by nullifying placeholders
            for (int i = 0; i < length; i++)
            {
                // check if cards[i] is null (if the card is drawn from the deck)
                // if null, shift the next elements to that spot length-1 times to fill the empty index left by drawn card
                if (cards[i] == null)
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        PlayingCard tmp = cards[length - 1];
                        cards[length - 1] = cards[j];
                        cards[j] = tmp;
                        length--;
                        j--;
                    }
                }
            }
            // returns the card drawn from the top
            return cardDrawn;
        }

        public DeckOfCards()
        {
            //initialize a fresh deck of cards in the DeckOfCards constructor
            FreshDeck();
        }

        // method for separately counting each instance in the deck of cards that is NOT null
        public int CardCounter()
        {
            int counter = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                // if cards index is not null, count the card
                if (cards[i] != null)
                {
                    counter++;
                }
            }
            return counter;
        }
        // method that gets a random card by creating a new playingcard object
        public static PlayingCard GetRandomCard()
        {
            return new PlayingCard();
        }
        // method that draws three cards from the top and prints them out to the console
        public static void DrawTopCards(DeckOfCards cardDeck)
        {
            try
            {
                Console.WriteLine($"\nRemove three cards from the top:\n");
                Console.WriteLine($"First card drawn: {cardDeck.GetTopCard()}");
                Console.WriteLine($"Second card drawn: {cardDeck.GetTopCard()}");
                Console.WriteLine($"Third card drawn:  {cardDeck.GetTopCard()}");
                Console.WriteLine();
                Console.WriteLine($"Remaining cards in the deck ({cardDeck.CardCounter()} cards): \n");
                Console.WriteLine(cardDeck);
            } 
            catch(Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
        }
    }
}
// - Randomly generate 3 cards using the using the default constructor (the one without
// parameters). Print them out
// - Initiate a fresh deck of cards with 52 Cards. Print out the deck
// - Shuffle the deck. Print out the shuffled deck