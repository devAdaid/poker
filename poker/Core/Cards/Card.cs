using System;

namespace Poker.Core
{
    public struct Card
    {
        public readonly CardRank Rank;
        public readonly CardSuit Suit;

        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Card(int value)
        {
            if (value < 1 || value > 52)
            {
                Suit = CardSuit.None;
                Rank = CardRank.None;
            }
            else
            {
                Suit = (CardSuit)((value - 1) % 4 + 1);
                Rank = (CardRank)((value - 1) / 4 + 1);
            }
        }

        public static int GetCardValue(CardSuit suit, CardRank rank)
        {
            int baseValue = ((int)rank - 1) * 4;
            int addValue = (int)suit - 1;
            return baseValue + addValue;
        }
    }
}
