namespace _09.House
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stars = n % 2 == 0 ? "**" : "*";

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(new string('-', ((n - 2) / 2) - i) + stars + new string('-', ((n - 2) / 2) - i));
                }
                else
                {
                    Console.WriteLine(new string('-', ((n - 1) / 2) - i) + stars + new string('-', ((n - 1) / 2) - i));
                }

                stars += "**";
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}
