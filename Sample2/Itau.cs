using System;

namespace solid.Sample2
{
    public class Itau : BankTemplate
    {
        public Itau(Action<string> writeLog) : base(writeLog)
        {
        }

        protected override decimal CalculateRates(decimal valueTransaction) => valueTransaction * 0.10m;
    }
}