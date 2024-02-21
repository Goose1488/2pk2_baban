using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Credit : Bank
    {
        public override void Deposit(decimal amount)
        {
            base.Deposit(amount + Balance * 0.1m);
        }

        public override void Withdraw(decimal amount)
        {
            decimal fee = amount * 0.1m;
            base.Withdraw(amount + fee);
        }

    }
}
