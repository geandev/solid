using solid.Sample2;

namespace solid.Controller
{
    public class RecommendController
    {
        private readonly IBankService _bankService;

        public static RecommendController Factory(IBankService bankService) => new RecommendController(bankService);

        private RecommendController(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void Transfer(BankType bankType, Account accountFrom, Account accountTo, decimal valueTransfer)
        {
            _bankService.Transfer(bankType, accountFrom, accountTo, valueTransfer);
        }
    }
}