using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();

            // Shuffle the cards using the Fisher-Yates shuffle
            pack.ShuffleCardPack(1);

            // Deal and print the cards
            Console.WriteLine("Dealing cards using the Fisher-Yates shuffle...");
            for (int i = 0; i < 5; i++)
            {
                Card card = pack.Deal();
                Console.WriteLine($"Card {i+1}: Value:{card.Value} of Suit:{card.Suit}");
            }

            // Shuffle the cards using the riffle shuffle
            pack.ShuffleCardPack(2);

            // Deal and print the cards
            Console.WriteLine("Dealing cards using the riffle shuffle...");
            for (int i = 0; i < 5; i++)
            {
                Card card = pack.Deal();
                Console.WriteLine($"Card {i+1}: Value:{card.Value} of Suit:{card.Suit}");
            }

            // Shuffle the cards using no shuffle
            pack.ShuffleCardPack(3);

            // Deal and print the cards
            Console.WriteLine("Dealing cards with no shuffle...");
            for (int i = 0; i < 5; i++)
            {
                Card card = pack.Deal();
                Console.WriteLine($"Card {i+1}: Value:{card.Value} of Suit:{card.Suit}");
            }

            Console.ReadKey();
        }
    }
}
