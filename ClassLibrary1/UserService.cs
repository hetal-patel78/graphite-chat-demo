using System;
using ClassLibrary1;

public class UserService
{
    public void CreateUser(string name, string email)
    {
        Console.WriteLine("Creating user: " + name);
        var user = new User
        {
            Name = name,
            Email = email
        };

        SaveToDatabase(user);
    }

    private void SaveToDatabase(User user)
    {
        // just a placeholder
        Console.WriteLine("User saved to DB.");
    }
}