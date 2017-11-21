namespace solid.Sample2
{
    public class BankService : IBankService
    {
        private readonly IBankFactory _bankFactory;

        public static BankService Factory(IBankFactory bankFactory) => new BankService(bankFactory);

        private BankService(IBankFactory bankFactory)
        {
            _bankFactory = bankFactory;
        }

        public void Transfer(BankType bankType, Account accountFrom, Account accountTo, decimal valueTransfer)
        {
            _bankFactory.Factory(bankType)
                .Transfer(accountFrom, accountTo, valueTransfer);
        }
    }
}