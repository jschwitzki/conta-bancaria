using System;
using poo.Classes;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste iniciando uma conta com saldo negativo.
            /* BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exceção pega tentando criar conta com saldo negativo.");
                Console.WriteLine(e.ToString());
                return;
            } */

            BankAccount client = new BankAccount("José", 500);
            Console.WriteLine($"Número: {client.Number} - Cliente: {client.Owner} - Saldo: {client.Balance}");
            client.MakeWithdrawal(500, DateTime.Now, "Aluguel");
            client.MakeDeposit(1000, DateTime.Now, "Salário");
            Console.WriteLine(client.GetAccountHistory());

            // Teste para um saldo negativo.
            /* try
            {
                client.MakeWithdrawal(750, DateTime.Now, "Tentativa de saque");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exceção pega tentando sacar mais que o possível.");
                Console.WriteLine(e.ToString());
            } */

            var giftCard = new GiftCardAccount("Gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Cafézinho");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Compras do mês");
            giftCard.PerformMonthEndTransactions();
            // Novos depósitos
            giftCard.MakeDeposit(27.50m, DateTime.Now, "Novo depósito");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("Counta poupança", 10000);
            savings.MakeDeposit(750, DateTime.Now, "Depositando um pouco");
            savings.MakeDeposit(1250, DateTime.Now, "Depositando mais dinheiro");
            savings.MakeWithdrawal(250, DateTime.Now, "Pagamento necessário");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("Linha de crédito", 0, 2000);
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Empréstimo necessário");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pagando um pouco.");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Fundos de emergência");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Pagando mais um pouco");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
    }
}