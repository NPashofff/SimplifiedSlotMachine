namespace SimplifiedSlotMachine.Core
{
    public class WriteToConsole : IWrite
    {
        public static void WriteWinAndBalance(decimal win, decimal depositAmount)
        {
            Console.WriteLine();
            Console.WriteLine(GlobalConstants.YouHaveWon, win);
            Console.WriteLine(GlobalConstants.CurrentBalance, depositAmount);
            Console.WriteLine();
        }

        public static void EmptyRow()
        {
            Console.WriteLine();
        }

        public static void WriteSpinRow(ICollection<char> row)
        {
            Console.WriteLine(string.Join("", row));
        }
    }
}
