namespace _08.Sunglasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string('|', n) + "*" + new string('/', n * 2 - 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string(' ', n) + "*" + new string('/', n * 2 - 2) + "*");
                }
            }

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        }
    }
}
