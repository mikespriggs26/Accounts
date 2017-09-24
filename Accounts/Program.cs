using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {

            string userOption = default(string);

            CheckingAccount check = new CheckingAccount();
            SavingsAccount save = new SavingsAccount();
            Client customer = new Client();



        
            customer.Welcome();

            Console.WriteLine("Please select a number from the list below and press enter.");

        
            while (userOption != "5")
            {


                List<string> clientOptions = new List<string>();        //Main Menu of options
                clientOptions.Add("1. View Client Information");
                clientOptions.Add("2. View Account Balance Information");
                clientOptions.Add("3. Make a Deposit");
                clientOptions.Add("4. Make a Withdrawal");
                clientOptions.Add("5. Exit");

                foreach (string option in clientOptions)
                {
                    Console.WriteLine(option);
                }

                userOption = Console.ReadLine();

                if (userOption == "1")
                {
                    customer.AccountInfo();
                    
                }
                else if (userOption == "2")     //User account info
                {
                AccountBalanceMenu:
                    Console.WriteLine("View which account balance: \n1. Checking \n2. Savings \n");
                    string accountInfoInput = Console.ReadLine();
                    if (accountInfoInput == "1")
                    {
                        check.AccountBalance();         //shows balance
                    }
                    else if (accountInfoInput == "2")
                    {
                        save.AccountBalance();          //shows balance
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid selection.  Please try again.");
                        goto AccountBalanceMenu;

                    }


                }
                else if (userOption == "3")     //Make a deposit
                {

                    // AccountSelection:
                    Console.WriteLine("Into which account: \n1. Checking \n2. Savings \n");
                    string userAccountInput = Console.ReadLine();

                    if (userAccountInput == "1")   //Deposit -> Checking
                    {
                    //CheckingDepositInput:
                        check.AccountBalance();
                        Console.WriteLine("How much would you like to deposit? Do not enter a dollar sign.");
                        check.CheckingDeposit = decimal.Parse(Console.ReadLine());
                        check.Deposit();                   //shows deposit amount and new balance
                        
                    }

                    if (userAccountInput == "2")   //  Deposit -> Savings
                    {
                    //SavingsDepositInput:
                        save.AccountBalance();
                        Console.WriteLine("How much would you like to deposit? Do not enter a dollar sign.");
                        save.SavingsDeposit = decimal.Parse(Console.ReadLine());
                        save.Deposit();         //shows deposit amount and new balance 
                        
                    }
                   


                }    //  End of 3 .Make a deposit





                else if (userOption == "4")     //  Withdraw funds
                {
                    // AccountSelection
                    Console.WriteLine("From which account: \n1. Checking \n2. Savings \n");
                    string userAccountInputW = Console.ReadLine();

                    if (userAccountInputW == "1")   //Withdraw -> Checking
                    {
                        
                        check.AccountBalance();
                        Console.WriteLine("How much would you like to withdraw? Do not enter a dollar sign.");
                        check.CheckingWithdrawal = decimal.Parse(Console.ReadLine());
                        check.Withdrawal();       //show withdrawal amount and new balance 
                        
                    }

                    if (userAccountInputW == "2")   //  Withdraw -> Savings
                    {
                   
                        save.AccountBalance();
                        Console.WriteLine("How much would you like to withdraw? Do not enter a dollar sign.");
                        save.SavingsWithdrawal = decimal.Parse(Console.ReadLine());
                        save.Withdrawal();      //shows withdrawal amount and new savings balance
                        
                    }




                }
                else if (userOption == "5")     //  Exit
                {
                    customer.Goodbye();
                }

                else
                {
                    Console.WriteLine("That is not a valid option.  Please start over.");
                   
                }
                
            }

        }
    }
}
