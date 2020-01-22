using System;
using Banking.Models;

namespace Banking.Cli{
    public abstract class View{
        public IConsole Shell{get; private set;}
        public IRepository Repository{get; private set;}
        public View(string header, IConsole shell, IRepository repo){
            Shell = shell;
            Repository = repo;
        }

        public abstract void Show();
    }

     public class CreateAccountView : View{
       
        public CreateAccountView(string header, IConsole shell, IRepository repo)
        :base(header, shell,repo){
            
        }
        public override void Show(){
            Shell.Write("Account No:");
            var accountId = Convert.ToInt32(Shell.ReadLine());
            Shell.Write("Balance:");
            var amount = Convert.ToDecimal(Shell.ReadLine());
            var account = new Account(accountId, amount);
            Repository.Save(account);
            Shell.WriteLine($"Account {accountId} created successfully");
            Shell.WriteLine("Press Enter to continue...");
            Shell.ReadLine();
        }
    }
}