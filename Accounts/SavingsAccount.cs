using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accounts
{
    class SavingsAccount : MainAccount
    {

        private decimal savingsBalance;
        private decimal savingsDeposit;
        private decimal savingsWithdrawal;

        public SavingsAccount()
        {
            this.savingsBalance = 3000;

        }



        public decimal SavingsDeposit { get; set; }

        public decimal SavingsWithdrawal { get; set; }


        public override void Deposit()
        {
            Console.WriteLine("Beginning balance is $" + savingsBalance);
            savingsBalance += SavingsDeposit;
            Console.WriteLine("You have deposited: $" + SavingsDeposit);
            Console.WriteLine("Your new Savings Account balance is $" + savingsBalance + ".");
            Console.WriteLine("----------------------------------------");
            

        }
        public override void AccountBalance()
        {
            Console.WriteLine("The balance for account #1234-Savings is $" + savingsBalance + ".");

        }


        public override void Withdrawal()
        {
            if (savingsBalance >= SavingsWithdrawal)
            {
                Console.WriteLine("Beginning balance is $" + savingsBalance);
                savingsBalance -= SavingsWithdrawal;
                Console.WriteLine("You have withdrawn: $" + SavingsWithdrawal + ".");
                Console.WriteLine("Your new Checking Account balance is $" + savingsBalance + ".");
                Console.WriteLine("----------------------------------------");
                
            }
            else
            {
                Console.WriteLine("You do not have sufficient funds. Please try again.");

            }
        }

    }
}
