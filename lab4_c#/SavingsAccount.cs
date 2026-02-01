using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class SavingsAccount : Account
    {
        int interestRate;
        int minimumBalance;
        public SavingsAccount(int num, string ownerName, int balance, int interestRate, int minimumBalance):base(num,ownerName,balance)
        {
            this.interestRate = interestRate;
            this.minimumBalance = minimumBalance;
        }

        public override int CalculateInterest()
        {
            return this.Balance * this.interestRate;
        }
        public override void Withdraw(int amount)
        {
            if (Balance - amount >= minimumBalance)
            {
               
              base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine($"Cannot withdraw {amount}. Minimum balance {minimumBalance} required.");
            }
        }
        

    }
}
