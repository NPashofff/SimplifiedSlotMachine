namespace SimplifiedSlotMachine.Core
{
    public static class GlobalConstants
    {
        public const string PleaseDepositMoney = "Please deposit money you wold like to play whit:";
        public const string PleaseEnterNumber = "Please enter number";
        public const string PleaseEnterPositiveNumber = "Please enter number bigger then 0";
        public const string EnterStakeAmount = "Enter stake amount:";
        public const string NotEnoughMoney = "Not enough money";
        public const string YouHaveWon = "You have won: {0}";
        public const string CurrentBalance = "Current balance is: {0}";
        public const char A = 'A';
        public const char B = 'B';
        public const char P = 'P';
        public const char Wc = '*';
        public const int TotalPercentage = 100;
        public const int APercentage = 45;
        public const int BPercentage = 35;
        public const int PPercentage = 15;
        public const int WcPercentage = 5;
        public const decimal ACoefficient = 0.4m;
        public const decimal BCoefficient = 0.6m;
        public const decimal PCoefficient = 0.8m;

        public static readonly Dictionary<char, int> Symbols = new()
        {
            {A, APercentage},
            {B, BPercentage},
            {P, P},
            {Wc, WcPercentage }
        };
    }
}
