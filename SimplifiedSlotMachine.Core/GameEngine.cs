using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedSlotMachine.Core
{
    public static class GameEngine
    {
        public static decimal CalculateWiningCoefficient(ICollection<char> row)
        {
            decimal result = 0;
            foreach (char c in row)
            {
                if (c == 'A')
                {
                    result += 0.4m;
                }
                else if (c == 'B')
                {
                    result += 0.6m;
                }
                else if (c == 'P')
                {
                    result += 0.8m;
                }
            }
            return result;
        }

        public static bool IsWining(ICollection<char> row)
        {
            var arr = row.ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1]) return false;
            }

            return true;
        }
    }
}
