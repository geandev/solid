using System;
using Solid.Controller;
using s1 = Solid.Sample1;
using s2 = Solid.Sample2;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========   With Clean Code  =========");
            WithCleanCode();

            Console.WriteLine("========== Without Clean Code =========");
            WithoutCleanCode();
        }

        static void WithCleanCode()
        {
            var accountFrom = s2.Account.Factory(500m);
            var accountTo = s2.Account.Factory(1000m);

            var bankService = s2.BankService.Factory(s2.BankFactory.Instance(Console.WriteLine));

            RecommendController.Factory(bankService)
            .Transfer(s2.BankType.Itau, accountFrom, accountTo, 200);
        }

        static void WithoutCleanCode()
        {
            var accountFrom = new s1.Account
            {
                Id = "Id1",
                Balance = 500m
            };


            var accountTo = new s1.Account
            {
                Id = "Id1",
                Balance = 1000m
            };

            var controller = new AvoidController();

            controller.Transfer(s1.BankType.Itau, accountFrom, accountTo, 200);
        }
    }
}
