using System;

namespace solid.Sample2
{
    public class Account
    {
        public string Id { get; private set; }
        public decimal Balance { get; private set; }
        public static Account Factory(decimal balance) => new Account(balance);
        private Account(decimal balance)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Balance = balance;

        }

        public void Withdraw(decimal valueToDraw)
        {
            this.Balance -= valueToDraw;
        }

        public void Deposit(decimal valueToDeposit)
        {
            this.Balance += valueToDeposit;
        }

        public override string ToString() => $"The balance is: {Balance}";

    }
}