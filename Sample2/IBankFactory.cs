using System;

namespace solid.Sample2
{
    public interface IBankFactory
    {
        BankTemplate Factory(BankType bankType);
    }
}