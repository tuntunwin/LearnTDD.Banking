namespace Banking.Models
{
    public interface IEmailService
    {
        bool SendTo(string toAddr, string subject, string message);
    }
}