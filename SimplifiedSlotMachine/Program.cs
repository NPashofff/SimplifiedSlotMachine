using SimplifiedSlotMachine;
using SimplifiedSlotMachine.Core;


var depositAmount = ReadFromConsole.DepositAmount();

//Game:
while (depositAmount > 0)
{
    var stakeAmount = ReadFromConsole.StakeAmount(depositAmount);
    var rows = new List<ICollection<char>>();

    for (int i = 0; i < 4; i++)
    {
        var row = Generator.GenerateRow();
        rows.Add(row);
    }

    foreach (var row in rows)
    {
        Console.WriteLine(string.Join("", row));
    }
}

var x = 0;