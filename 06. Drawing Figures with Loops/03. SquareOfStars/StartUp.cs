﻿namespace _03.SquareOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
