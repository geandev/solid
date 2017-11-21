using System;
using System.Collections.Generic;

namespace solid.Sample2
{
    public class BankFactory : IBankFactory
    {
        private readonly Dictionary<BankType, Func<BankTemplate>> _bankTypes;
        private BankFactory(Action<string> writeLog)
        {
            _bankTypes = new Dictionary<BankType, Func<BankTemplate>>
            {
                [BankType.Itau] = () => new Itau(writeLog),
                [BankType.Caixa] = () => new Caixa(writeLog),
            };

        }
        public static IBankFactory Instance(Action<string> writeLog) => new BankFactory(writeLog);

        public BankTemplate Factory(BankType bankType)
        {
            return this._bankTypes.GetValueOrDefault(bankType)?.Invoke();
        }
    }
}