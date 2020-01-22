using Banking.Models;

namespace Banking.Cli
{
    public abstract class View{
        public string Header{get; set;}
        public IShell Shell{get; private set;}
        public IRepository Repository{get; private set;}
        public View(string header, IShell shell, IRepository repo){
            Header = header;
            Shell = shell;
            Repository = repo;
        }
        public void Show(){
            ShowHeader();
            ShowContent();
        }

        protected abstract void ShowContent();

        private void ShowHeader(){
            Shell.WriteLine("--------------------");
            Shell.WriteLine(Header);
            Shell.WriteLine("--------------------");
        }
    }
}