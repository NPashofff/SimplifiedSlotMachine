namespace SimplifiedSlotMachine.Core
{
    public static class GameEngine
    {
        public static decimal CalculateWiningCoefficient(ICollection<char> row)
        {
            decimal result = 0;
            foreach (char c in row)
            {
                switch (c)
                {
                    case GlobalConstants.A:
                        result += GlobalConstants.ACoefficient;
                        break;
                    case GlobalConstants.B:
                        result += GlobalConstants.BCoefficient;
                        break;
                    case GlobalConstants.P:
                        result += GlobalConstants.PCoefficient;
                        break;
                }
            }
            return result;
        }

        public static bool IsWining(ICollection<char> row)
        {
            var arr = row.ToArray();

            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1]) return false;
            }

            return true;
        }
    }
}
