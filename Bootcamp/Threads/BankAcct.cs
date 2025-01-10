using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Threads
{
    public class BankAcct(double bal)
    {
        private readonly Object acctLock = new();
        double Balance { get; set; } = bal;

        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }

            lock (acctLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account",
                    amt, (Balance - amt));
                    Balance -= amt;
                }

                return Balance;

            }
        }

        // You can only point at methods
        // without arguments and that return 
        // nothing
        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}