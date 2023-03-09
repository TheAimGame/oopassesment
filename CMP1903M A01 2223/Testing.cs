using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        static void Test(string[] args)
        {
            Pack pack = new Pack();
            pack.ShuffleCardPack(1); // Fisher-Yates Shuffle
            Console.WriteLine("Fisher-Yates Shuffle:");
            DealAndPrintCards(pack);

            pack.ShuffleCardPack(2); // Riffle Shuffle
            Console.WriteLine("\nRiffle Shuffle:");
            DealAndPrintCards(pack);

            pack.ShuffleCardPack(3); // No Shuffle
            Console.WriteLine("\nNo Shuffle:");
            DealAndPrintCards(pack);

            Console.ReadLine();
        }

        static void DealAndPrintCards(Pack pack)
        {
            Console.WriteLine("Dealing 5 cards:");
            var cards = pack.DealCard(5);
            foreach (var card in cards)
            {
                Console.WriteLine($"Value:{card.Value} of Suit:{card.Suit}");
            }
        }
    }
}