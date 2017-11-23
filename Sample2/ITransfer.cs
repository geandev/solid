namespace Solid.Sample2
{
    public interface ITransfer
    {
        void Transfer(Account fromAccount, Account toAccount, decimal valueTransfer);
    }
}