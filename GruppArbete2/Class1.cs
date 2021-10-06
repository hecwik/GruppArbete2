using System;

namespace GroupAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prinout 3 random cards
            Console.WriteLine($"\n3 randomly generated cards:");
            Console.WriteLine("--" + new PlayingCard());
            Console.WriteLine(new PlayingCard());
            Console.WriteLine(new PlayingCard());

            DeckOfCards myDeck = new DeckOfCards();
            Console.WriteLine($"\nA freshly created deck with {myDeck.Count} cards:");
            Console.WriteLine(myDeck);

            myDeck.Shuffle();
            Console.WriteLine($"\nA shuffled deck with {myDeck.Count} cards:");
            Console.WriteLine(myDeck);

            //For the Challange
            /*
            Console.WriteLine($"\nRemove three card from the top:");
            Console.WriteLine(myDeck.GetTopCard());
            Console.WriteLine(myDeck.GetTopCard());
            Console.WriteLine(myDeck.GetTopCard());

            Console.WriteLine($"\nDeck has now {myDeck.Count} cards:");
            Console.WriteLine(myDeck);
            */
        }
    }
}