namespace SimplifiedSlotMachine.Core
{
    public static class Read
    {
        public static decimal Input()
        {
            //todo: While true is no good. Fix it
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
