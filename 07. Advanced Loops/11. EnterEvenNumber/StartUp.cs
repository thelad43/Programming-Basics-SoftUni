namespace _11.EnterEvenNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n;

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 1)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    else
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
