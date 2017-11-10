namespace _06.RhombusOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            for (int row = n - 1; row > 0; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
