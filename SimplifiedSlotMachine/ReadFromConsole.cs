namespace SimplifiedSlotMachine.Core
{
    public static class ReadFromConsole
    {
        public static decimal DepositAmount()
        {
            Console.WriteLine(GlobalConstants.PleaseDepositMoney);

            return ValidateInput();
        }

        public static decimal StakeAmount(decimal depositAmount)
        {
            Console.WriteLine(GlobalConstants.EnterStakeAmount);

            while (true)
            {
                var stakeAmount = ValidateInput();
                if(depositAmount >= stakeAmount) return stakeAmount;

                Console.WriteLine(GlobalConstants.NotEnoughMoney);
            }

        }

        private static decimal ValidateInput()
        {
            while (true)
            {
                var input = Console.ReadLine();
                var isInputValid = decimal.TryParse(input, out var depositAmount);

                if (!isInputValid)
                {
                    Console.WriteLine(GlobalConstants.PleaseEnterNumber);
                    continue;
                }

                if (depositAmount > 0) return depositAmount;

                Console.WriteLine(GlobalConstants.PleaseEnterPositiveNumber);
            }
        }
    }
}
