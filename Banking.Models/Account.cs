using System;
using System.Collections.Generic;

namespace Banking.Models
{
    public class Account
    {
        IEmailService mailer;
        public int AccountId{get; private set;}
        public decimal Balance { get; private set; }
        public Account(int accountId, decimal balance = 0){
            AccountId = accountId;
            Balance = balance;
        }
        

        public void Deposite(decimal v)
        {
           
            try{
                this.mailer?.SendTo("fool customer", "fool subject", $"{v} is deposited.");
                 Balance += v;
                 
            }catch(Exception ex){
                
                Console.WriteLine("Error occour " + ex);
                throw;
            }
            
        }

        public void Withdraw(int value)
        {
            if(value <= this.Balance){
                this.Balance -=  value;
            }
            else
                //throw new ArgumNotEnoughtBalanceExeption($"Not enought balance {this.Balance} ", "value");
                throw new NotEnoughtBalanceExeption(this.Balance);
            
        }
    }
}