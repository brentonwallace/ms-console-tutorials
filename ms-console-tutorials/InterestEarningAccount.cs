﻿using System;


namespace ms_console_tutorials
{

    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.5m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");

            }
        }
    }

}
    
    
    
