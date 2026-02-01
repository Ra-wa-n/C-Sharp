using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class CheckingAccount:Account
    {
        public double OverdraftLimit { get; set; }
        public CheckingAccount(int num, string ownerName, int balance, double overdraftLimit):base(num,ownerName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(int amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded!");
            }
        }
        public override int CalculateInterest()
        {
            return 0; 
        }
        public override int Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return this.Balance;
            }
            return 0;
        }
    }
}
