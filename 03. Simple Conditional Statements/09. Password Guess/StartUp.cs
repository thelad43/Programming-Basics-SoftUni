namespace _09.Password_Guess
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var pass = Console.ReadLine();

            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }
        }
    }
}
