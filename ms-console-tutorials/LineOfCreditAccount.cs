using System;


namespace ms_console_tutorials
{

    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance/* decimal creditLimit*/) : base(name, initialBalance)
        {
            // Parameter "decimal creditLimit" - unsure how it got there but is unused and causes errors
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:

                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }


    }

}
