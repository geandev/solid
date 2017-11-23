using System;
using System.Collections.Generic;

namespace Solid.Sample2
{
    public class BankFactory : IBankFactory
    {
        private readonly Action<string> _writeLog;

        private Dictionary<BankType, Func<Action<string>, BankTemplate>> BankFactoryTypes => new Dictionary<BankType, Func<Action<string>, BankTemplate>>
        {
            [BankType.Itau] = (log) => new Itau(log),
            [BankType.Caixa] = (log) => new Caixa(log)
        };

        private BankFactory(Action<string> writeLog)
        {
            _writeLog = writeLog;
        }
        public static IBankFactory Instance(Action<string> writeLog) => new BankFactory(writeLog);

        public BankTemplate Factory(BankType bankType) => BankFactoryTypes.GetValueOrDefault(bankType) ? .Invoke(_writeLog);
    }
}