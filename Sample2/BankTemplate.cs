using System;

namespace solid.Sample2
{
    public abstract class BankTemplate : ITransfer
    {
        private readonly Action<string> _writeLog;

        protected BankTemplate(Action<string> writeLog)
        {
            _writeLog = writeLog;
        }
        public void Transfer(Account fromAccount, Account toAccount, decimal valueTransaction)
        {
            _writeLog($"transfer value: {valueTransaction}");

            fromAccount.Withdraw(valueTransaction);
            fromAccount.Withdraw(LogAndCalculateRates(valueTransaction));
            toAccount.Deposit(valueTransaction);

            _writeLog($"from details: {fromAccount}");
            _writeLog($"to details: {toAccount}");
        }

        private decimal LogAndCalculateRates(decimal valueTransaction)
        {
            var rates = CalculateRates(valueTransaction);
            _writeLog($"{this.GetType().Name} tax: {rates}");
            return rates;
        }

        protected virtual decimal CalculateRates(decimal valueTransaction) => 0;
    }
}