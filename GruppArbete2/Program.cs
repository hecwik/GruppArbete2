using System;

namespace GroupAssignment2
{
    /// MADE BY: KARLSTAD && PAJALA 
    /// 
    /// LOUISE LITTECKE
    /// HANNA TEKIE
    /// LEO DIBINGER
    /// HECTOR WIKLUND
    /// ADRIAN BJÖRKRYD
    
    class Program
    {
        static void Main(string[] args)
        {
            //Print out 3 random cards

            // calling method for getting a random card three times
            Console.WriteLine($"\n3 randomly generated cards:\n");
            Console.WriteLine(DeckOfCards.GetRandomCard());
            Console.WriteLine(DeckOfCards.GetRandomCard());
            Console.WriteLine(DeckOfCards.GetRandomCard());

            DeckOfCards myDeck = new DeckOfCards();

            Console.WriteLine($"\nA freshly created deck with {myDeck.Count} cards:\n");
            Console.WriteLine(myDeck);

            myDeck.Shuffle(myDeck);

            // CHALLENGE PART //

            DeckOfCards.DrawTopCards(myDeck);
            
        }
    }
}