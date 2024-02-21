using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Accum : Bank
    {
        public override void Deposit(decimal amount)
        {
            if (amount >= 10000)
            {
                base.Deposit(amount);
            }
        }

        public decimal InterestRate { get; set; }
        public int WithdrawAfterYears(int years, decimal Balance)
        {
            int i = 0;
            while (i < years)
            {
                Balance += Balance / 10;
                i++;
            }
            return Convert.ToInt32(Balance);
        }
    }
}
