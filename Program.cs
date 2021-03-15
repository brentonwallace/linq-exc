using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_exc
{
    class Program
    {

        static void Main(string[] args)
        {
           
         // FOllowing methods called QUERY SYNTAX
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r }; 
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }


            // Same query written in METHOD SYNTAX
            /*  var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));      */

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);


        }



        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
