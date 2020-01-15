using System;
using System.Collections.Generic;

namespace Banking.Models
{
    public class Account
    {
        IEmailService mailer;
        public Account(int balance = 0, IEmailService mailer = null){
            Balance = balance;
            this.mailer = mailer;
        }
        public decimal Balance { get; private set; }

        public void Deposite(decimal v)
        {
           
            try{
                this.mailer.SendTo("fool customer", "fool subject", $"{v} is deposited.");
                 Balance += v;
            }catch(Exception ex){
                
                Console.WriteLine("Error occour " + ex);
                throw;
            }
            
        }
    }
}