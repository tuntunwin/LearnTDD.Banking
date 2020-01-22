using System;
namespace Banking.Models
{
    public interface IRepository
    {
        void Save(Account account);
        
    }    
}
