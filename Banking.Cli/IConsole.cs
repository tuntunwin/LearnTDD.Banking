using System;

public interface IConsole
{
    void WriteLine(string value);
    void Write(string value);
    string ReadLine();

    
}

public class ShellConsole : IConsole{
     public void WriteLine(string value){Console.WriteLine(value);}
    public void Write(string value){Console.Write(value);}
    public string ReadLine(){return Console.ReadLine();}

}