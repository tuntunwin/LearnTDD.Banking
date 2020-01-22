using System;
using Banking.Models;

namespace Banking.Cli
{
    public class CreateAccountView : View{
       
        public CreateAccountView(string header, IShell shell, IRepository repo)
        :base(header, shell,repo){
            
        }
        protected override void ShowContent(){
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