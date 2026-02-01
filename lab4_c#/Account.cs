using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
abstract class Account :IPrintable,ITransactable
    {
    public int AccountNumber { get; } 
    public int Balance { get; protected set; } 
  string OwnerName { get; set; }
        public Account( int num,string ownerName, int balance)
        {
            AccountNumber =num ;
            OwnerName = ownerName;
            Balance = balance;
        }
        public abstract int CalculateInterest();
        public virtual void Print() { }
        public virtual int Deposit( int amount) { return 0; }
        public virtual void Withdraw(int amount)
        {
            if (amount <= Balance)
            {
               this. Balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}
