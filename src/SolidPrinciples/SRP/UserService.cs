using System;

namespace OOPs.src.SolidPrinciples.SRP;

public class UserService
{
    // here all the business logic related to the User is put

    public void Register(User user)
    {
        //register user logic
        //something like fetching the user from the data base, 
        // if their email exists, re-direct them to the login page
        //send emeail
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.Email,"Welcome to our platform");

    }

}
