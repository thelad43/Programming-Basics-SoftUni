namespace _14.NumberTable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = row + col + 1;
                    if (num > n)
                        num = 2 * n - num;
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
        }
    }
}
