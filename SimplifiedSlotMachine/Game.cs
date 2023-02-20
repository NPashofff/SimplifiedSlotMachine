using SimplifiedSlotMachine.Core;

namespace SimplifiedSlotMachine
{
    public class Game
    {
        private decimal _depositAmount = ReadFromConsole.DepositAmount();

        public void Start()
        {
            while (_depositAmount > 0)
            {
                var stakeAmount = ReadFromConsole.StakeAmount(_depositAmount);
                WriteToConsole.EmptyRow();
                var rows = new List<ICollection<char>>();
                decimal win = 0;

                for (var i = 0; i < 4; i++)
                {
                    var row = Generator.GenerateRow();
                    rows.Add(row);
                    WriteToConsole.WriteSpinRow(row);

                    var isWin = GameEngine.IsWining(row);
                    if (!isWin) continue;

                    var coefficient = GameEngine.CalculateWiningCoefficient(row);
                    win += coefficient * stakeAmount;
                }

                if (win == 0)
                {
                    _depositAmount -= stakeAmount;
                }
                else
                {
                    _depositAmount += win;
                }

                WriteToConsole.WriteWinAndBalance(win, _depositAmount);
            }
        }
    }
}
