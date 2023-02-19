using SimplifiedSlotMachine;
using SimplifiedSlotMachine.Core;


var depositAmount = ReadFromConsole.DepositAmount();

//Game:
while (depositAmount > 0)
{
    var stakeAmount = ReadFromConsole.StakeAmount(depositAmount);

    for (int i = 0; i < 4; i++)
    {
        List<char> rolSymbols = new List<char>();
    }
}

var x = 0;