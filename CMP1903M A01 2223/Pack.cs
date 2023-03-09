using System;
using System.Collections.Generic;
using System.Linq;


namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> pack;

        public Pack()
        {
            // Initialize the card pack here
            pack = new List<Card>();
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    pack.Add(new Card(i, j));
                }
            }
        }

        public bool ShuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                case 1:
                    // Fisher-Yates Shuffle
                    Random rand = new Random();
                    for (int i = pack.Count - 1; i >= 1; i--)
                    {
                        int j = rand.Next(i + 1);
                        Card temp = pack[j];
                        pack[j] = pack[i];
                        pack[i] = temp;
                    }
                    return true;
                case 2:
                    // Riffle Shuffle
                    List<Card> half1 = pack.Take(pack.Count / 2).ToList();
                    List<Card> half2 = pack.Skip(pack.Count / 2).ToList();
                    pack.Clear();
                    int count1 = 0, count2 = 0;
                    while (count1 < half1.Count && count2 < half2.Count)
                    {
                        pack.Add(half1[count1]);
                        pack.Add(half2[count2]);
                        count1++;
                        count2++;
                    }
                    while (count1 < half1.Count)
                    {
                        pack.Add(half1[count1]);
                        count1++;
                    }
                    while (count2 < half2.Count)
                    {
                        pack.Add(half2[count2]);
                        count2++;
                    }
                    return true;
                default:
                    // No Shuffle
                    return false;
            }
        }

        public Card Deal()
        {
            // Deals one card
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;
        }

        public List<Card> DealCard(int amount)
        {
            // Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(Deal());
            }
            return cards;
        }
    }
}
