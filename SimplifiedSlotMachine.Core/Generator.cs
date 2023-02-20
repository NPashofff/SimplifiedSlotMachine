namespace SimplifiedSlotMachine.Core
{
    public static class Generator
    {
        private static readonly Random Random = new Random();
        private const int TotalPercentage = GlobalConstants.TotalPercentage;
        private static readonly Dictionary<char, int> Symbols = GlobalConstants.Symbols;

        private static char GetRandomSymbol()
        {
            var randomNumber = Random.Next(TotalPercentage);
            var cumulativePercentage = 0;

            foreach (var symbol in Symbols)
            {
                cumulativePercentage += symbol.Value;

                if (randomNumber < cumulativePercentage)
                {
                    return symbol.Key;
                }
            }

            return Symbols.First().Key;
        }

        public static ICollection<char> GenerateRow()
        {
            var row = new char[3];

            for (var i = 0; i < row.Length; i++)
            {
                row[i] = GetRandomSymbol();
            }

            return row;
        }
    }
}
