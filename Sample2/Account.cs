using System;

namespace Solid.Sample2
{
    public class Account
    {
        public string Id { get; private set; }
        public decimal Balance { get; private set; }
        public static Account Factory(decimal balance) => new Account(balance);
        private Account(decimal balance)
        {
            Id = Guid.NewGuid().ToString();
            Balance = balance;

        }

        public void Withdraw(decimal valueToDraw)
        {
            Balance -= valueToDraw;
        }

        public void Deposit(decimal valueToDeposit)
        {
            Balance += valueToDeposit;
        }

        public override string ToString() => $"The balance is: {Balance}";

    }
}