using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Debit : Bank
    {
        public override void Deposit(decimal amount)
        {
            if (amount >= 100)
            {
                base.Deposit(amount);
            }
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
        }
    }
}
