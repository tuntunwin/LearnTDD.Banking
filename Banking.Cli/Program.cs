using System;
using Banking.Models;

namespace Banking.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new FileRepository(".");
            do
            {
                int choice = ShowOption();

                switch (choice)
                {
                    //var choice = input - '0';//Char.GetNumericValue(input);
                    case 1:
                        if (choice == 1)
                        {
                            CreateAccount(repo);
                        }
                        break;

                    default:
                        break;
                }
            } while (true);
            
        }

        private static int ShowOption()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Options");
            Console.WriteLine("--------------------");
            Console.WriteLine("1)Create New Account");
            Console.WriteLine("2)Deposite");
            Console.WriteLine("3)Withdraw");
            Console.WriteLine("4)Transfer");
            Console.Write("Please Select:");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private static void CreateAccount(FileRepository repo)
        {
            var view = new CreateAccountView("Create New Account", 
                new ShellConsole(), 
                new FileRepository("."));
            view.Show();
            // Console.WriteLine("--------------------");
            // Console.WriteLine("Create New Account");
            // Console.WriteLine("--------------------");
            // Console.Write("Account No:");
            // var accountId = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Balance:");
            // var amount = Convert.ToDecimal(Console.ReadLine());
            // var account = new Account(accountId, amount);
            // repo.Save(account);
            // Console.WriteLine($"Account {accountId} created successfully");
            // Console.WriteLine("Press Enter to continue...");
            // Console.ReadLine();
        }
    }
}
