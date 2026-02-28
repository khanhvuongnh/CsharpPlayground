namespace CsharpPlayground.SOLID.S
{
    /*
        A class should have only one reason to change, meaning that it should have only one responsibility or purpose.
        In this example, the User class manages user data (username and email), and contains logic for registering a user. 
        This violates the SRP because the class has more than one reason to change. It could change due to:
            + Modifications in user data management – for example adding more fields, such as firstName, gender, hobbies.
            + Modifications to the logic of registering a user, for example we may choose to fetch a user from the database 
              by their username rather than their email.
        To adhere to the Single Responsibility Principle, we should separate these responsibilities into separate classes.
    */

    public class User
    {
        public string? Username { get; set; }
        public string? Email { get; set; }

        public void Register()
        {
            // Register user logic, e.g. save to database...

            // Send email notification
            if (Email == null) return;
            EmailSender.SendEmail("Welcome to our platform!", Email);
        }
    }

    public class EmailSender
    {
        public static void SendEmail(string message, string recipient)
        {
            // Email sending logic
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}

namespace CsharpPlayground.SOLID.S.Refactored
{
    public class User
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
    }

    public class UserService
    {
        public static void RegisterUser(User user)
        {
            // Register user logic...
            if (user.Email == null) return;
            EmailSender.SendEmail("Welcome to our platform!", user.Email);
        }
    }

    public class EmailSender
    {
        public static void SendEmail(string message, string recipient)
        {
            // Email sending logic
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}
