using System; // account class with a balance and a deposit method

namespace account.cs
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
    }
}