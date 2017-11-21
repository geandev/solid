using System;
using solid.Sample1;

namespace solid.Controller
{
    public class AvoidController
    {
        public void Transfer(BankType bankType, Account accountFrom, Account accountTo, decimal valueTransfer)
        {
            var bankService = new BankService();
            bankService.Transfer(bankType, accountFrom, accountTo, 200);
            Console.WriteLine($"account from balance: {accountFrom.Balance}");
            Console.WriteLine($"account to balance: {accountTo.Balance}");
        }
    }
}