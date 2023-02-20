using SimplifiedSlotMachine.Core;

namespace SimplifiedSlotMachine
{
    public class Game
    {
        decimal depositAmount = ReadFromConsole.DepositAmount();

        public void Start()
        {
            while (depositAmount > 0)
            {
                var stakeAmount = ReadFromConsole.StakeAmount(depositAmount);
                WriteToConsole.EmptyRow();
                var rows = new List<ICollection<char>>();
                decimal win = 0;

                for (int i = 0; i < 4; i++)
                {
                    var row = Generator.GenerateRow();
                    rows.Add(row);
                    WriteToConsole.WriteSpinRow(row);

                    var isWin = GameEngine.IsWining(row);
                    if (isWin)
                    {
                        var coefficient = GameEngine.CalculateWiningCoefficient(row);
                        win += coefficient * stakeAmount;
                    }
                }

                if (win == 0)
                {
                    depositAmount -= stakeAmount;
                }
                else
                {
                    depositAmount += win;
                }

                WriteToConsole.WriteWinAndBalance(win, depositAmount);
            }
        }
    }
}
