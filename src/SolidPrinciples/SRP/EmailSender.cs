using System;

namespace OOPs.src.SolidPrinciples.SRP;

public class EmailSender
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"sending email to {email} : {message}");
    }
}
