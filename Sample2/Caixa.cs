using System;

namespace Solid.Sample2
{
    public class Caixa : BankTemplate
    {
        public Caixa(Action<string> writeLog) : base(writeLog)
        {
        }

        protected override decimal CalculateRates(decimal valueTransaction) => valueTransaction * 0.05m;
    }
}