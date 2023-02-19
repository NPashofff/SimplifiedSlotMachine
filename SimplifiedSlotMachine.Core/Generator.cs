namespace SimplifiedSlotMachine.Core
{
    public static class Generator
    {
        private static readonly Random random = new Random();
        private const int TotalPercentage = 100;

        private static readonly (char symbol, int percentage)[] symbols =
        {
                ('A', 45),
                ('B', 35),
                ('P', 15),
                ('*', 5)
        };

        public static char GetRandomSymbol()
        {
            int randomNumber = random.Next(TotalPercentage);
            int cumulativePercentage = 0;

            foreach (var symbol in symbols)
            {
                cumulativePercentage += symbol.percentage;

                if (randomNumber < cumulativePercentage)
                {
                    return symbol.symbol;
                }
            }

            return symbols[symbols.Length - 1].symbol;
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
