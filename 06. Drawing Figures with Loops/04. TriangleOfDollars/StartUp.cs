namespace _04.TriangleOfDollars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("$ ");
                }

                Console.WriteLine();
            }
        }
    }
}
