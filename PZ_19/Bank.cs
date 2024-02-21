using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Bank
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Holder { get; set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }

        }
        public static bool operator ==(Bank account, Bank accountt)
        {
            return account.AccountNumber == accountt.AccountNumber;
        }

        public static bool operator !=(Bank account, Bank accountt)
        {
            return account.AccountNumber != accountt.AccountNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj is Bank)
            {
                return this.AccountNumber == ((Bank)obj).AccountNumber;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return AccountNumber.GetHashCode();
        }

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