﻿namespace _05.SquareFrame
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");

                for (int k = 0; k < n - 2; k++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("|");
            }

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
