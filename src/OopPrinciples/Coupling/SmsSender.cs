
namespace OOPs.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine($"sms message, {message}");
        }
    }
}