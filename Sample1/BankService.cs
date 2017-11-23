using System;

namespace solid.Sample1
{
    public class BankService
    {
        public void Transfer(BankType bankType, Account fromAccount, Account toAccount, decimal valueTransfer)
        {
            Console.WriteLine($"transfer value: {valueTransfer}");
            
            fromAccount.Balance = fromAccount.Balance - valueTransfer;
            toAccount.Balance = toAccount.Balance + valueTransfer;

            switch (bankType)
            {
                case BankType.Caixa:
                    fromAccount.Balance = fromAccount.Balance - CalcRatesCaixa(valueTransfer);
                    break;
                case BankType.Itau:
                    fromAccount.Balance = fromAccount.Balance - CalcRatesItau(valueTransfer);
                    break;

            }
        }

        private decimal CalcRatesItau(decimal valueTransfer)
        {
            var taxValue = (valueTransfer * 0.10m);
            Console.WriteLine($"Itau tax: {taxValue} ");
            return taxValue;
        }

        private decimal CalcRatesCaixa(decimal valueTransfer)
        {
            var taxValue = (valueTransfer * 0.05m);
            Console.WriteLine($"Caixa tax: {taxValue} ");

            return taxValue;
        }
    }
}