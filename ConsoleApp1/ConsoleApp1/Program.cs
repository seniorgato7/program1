using System;
class Program
{
    static void Main(string[] args)
    {
        string username, password;
        int attempts = 0;

        for (; attempts < 3;)
        {
            Console.Write("Enter your Username hehe : ");
            username = Console.ReadLine();
            Console.Write("Enter your Password hehe : ");
            password = Console.ReadLine();

            if (username == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("Login successful yey ^^");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect username or password. Please try again lmao.");
                attempts++;
            }
        }
        if (attempts == 3)
        {
            Console.WriteLine("Maximum attempts reached. Try Harder.");
        }
    }
}