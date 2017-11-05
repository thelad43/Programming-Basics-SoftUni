namespace _06.Square_of_Stars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new String('*', n));

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', n - 2));
            }

            Console.WriteLine(new String('*', n));
        }
    }
}
