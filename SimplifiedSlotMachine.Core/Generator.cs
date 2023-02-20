namespace SimplifiedSlotMachine.Core
{
    public static class Generator
    {
        private static readonly Random random = new Random();
        private const int TotalPercentage = 100;

        private static readonly Dictionary<char, int> symbols = new()
        {
                {'A', 45},
                {'B', 35},
                {'P', 15},
                {'*', 5 }
        };

        private static char GetRandomSymbol()
        {
            var randomNumber = random.Next(TotalPercentage);
            var cumulativePercentage = 0;

            foreach (var symbol in symbols)
            {
                cumulativePercentage += symbol.Value;

                if (randomNumber < cumulativePercentage)
                {
                    return symbol.Key;
                }
            }

            return symbols.First().Key;
        }

        public static ICollection<char> GenerateRow()
        {
            var row = new char[3];

            for (int i = 0; i < row.Length; i++)
            {
                row[i] = GetRandomSymbol();
            }

            return row;
        }
    }
}
