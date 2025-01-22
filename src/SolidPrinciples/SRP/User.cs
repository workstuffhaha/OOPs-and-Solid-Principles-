using System;
using System.Reflection.Metadata;

namespace OOPs.src.SolidPrinciples.SRP
{
    // this class would have violated the SRP if it contained the business logic and also the public fields. 
    // so a UserService class is created for the same

    // User class is solely responsible for showing user data
    // this makes it easier to use the code, understand and update over time.

    public class User
    {
        public string Username {get; set;}
        public string Email{get; set;}

        
    }

}


