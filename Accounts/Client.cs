using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Client
    {
        //3 properties        1 constructor        1 method
        private string firstName = "John";
        private string lastName = "Smith";
        private string fullName = "John " + "Smith";
        private string accountNumber = "1234";

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }

        public Client()
        {
            firstName = "John";
            lastName = "Smith";
            accountNumber = "1234";
        }
        public virtual void AccountInfo()
        {
            Console.WriteLine("Account owner: \t" + firstName + " " + lastName);
            Console.WriteLine("Account #: \t" + accountNumber);
            
            Console.WriteLine();
        }

        public virtual void Welcome()
        {
            
            Console.WriteLine("Welcome to WCCI Bank! Please enter your name in order to log in:");
            string userInput = Console.ReadLine();

            while (userInput != fullName)
            {
                Console.WriteLine("That is not the name on the account. Please try again:");
                userInput = Console.ReadLine();
            }

           

        }

        public virtual void Goodbye()
        {
            
            Console.WriteLine("Thank you for banking with WCCI Bank.");
            Console.WriteLine();
            Environment.Exit(0);
            
        }




    }
}
