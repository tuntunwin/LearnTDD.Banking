using System.IO;
using Banking.Models;
namespace Banking.Models{
    public class FileRepository : IRepository{
        public string BasePath {get; private set;} 
        public FileRepository(string basePath) => BasePath = basePath;
        public void Save(Account account){
            var filePath = Path.Combine(BasePath, $"{account.AccountId}.acc");
            File.WriteAllText(filePath, account.ToString());
        }
    }
}
