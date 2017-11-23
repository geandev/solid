namespace Solid.Sample2
{
    public interface IBankService
    {
        void Transfer(BankType bankType, Account accountFrom, Account accountTo, decimal valueTransfer);
    }
}