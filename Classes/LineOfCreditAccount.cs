namespace poo.Classes
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        { }
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Cobra o interesse mensal.");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(Boolean isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Adicionar taxa de overdraft")
            : default;
    }
}