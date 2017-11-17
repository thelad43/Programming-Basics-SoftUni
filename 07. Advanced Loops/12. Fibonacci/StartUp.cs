namespace _12.Fibonacci
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;

            if (n < 2)
            {
                Console.WriteLine(1);
                return;
            }

            for (int i = 0; i < n - 1; i++)
            {
                var nextFibNum = f0 + f1;
                f0 = f1;
                f1 = nextFibNum;
            }

            Console.WriteLine(f1);
        }
    }
}
