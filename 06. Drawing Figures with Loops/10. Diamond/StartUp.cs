namespace _10.Diamond
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                Console.WriteLine(new string('*', n));
                return;
            }

            if (n % 2 == 0)
            {

                for (int i = 0; i < n / 2; i++)
                {
                    var dashes = new string('-', i * 2);
                    Console.WriteLine(new string('-', ((n - 1) / 2) - i) + "*" + dashes + "*" + new string('-', ((n - 1) / 2) - i));
                }

                var dashesCount = n - 4;

                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', dashesCount) + "*" + new string('-', i));
                    dashesCount -= 2;
                }
            }
            else
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
                var dashesCount = 1;

                for (int i = 1; i <= (n / 2 + 1) - 2; i++)
                {
                    Console.WriteLine(new string('-', (n - 2 - dashesCount) / 2) + "*" + new string('-', dashesCount) + "*" + new string('-', (n - 2 - dashesCount) / 2));
                    dashesCount += 2;
                }

                Console.WriteLine("*" + new string('-', n - 2) + "*");

                dashesCount = n - 4;
                for (int i = 1; i <= (n / 2 + 1) - 2; i++)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', dashesCount) + "*" + new string('-', i));
                    dashesCount -= 2;
                }

                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            }
        }
    }
}