using System;

namespace Solid.Sample2
{
    public interface IBankFactory
    {
        BankTemplate Factory(BankType bankType);
    }
}