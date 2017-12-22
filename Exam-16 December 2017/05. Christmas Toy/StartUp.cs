namespace _05.Christmas_Toy
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var height = 2 * n + 3;

            PrintFirstOrLastLine(n);

            var dashesCount = n * 2 - 2;
            var anpercantsCount = n + 2;
            var stars = "*";

            PrintFirstPart(n, ref dashesCount, ref anpercantsCount, ref stars, width);

            Console.Write(new string('-', n / 2));
            Console.Write("*");
            Console.Write(new string('|', width - (n + 2)));
            Console.Write("*");
            Console.WriteLine(new string('-', n / 2));

            PrintSecondPart(n, ref dashesCount, ref anpercantsCount, ref stars, width);

            PrintFirstOrLastLine(n);
        }

        private static void PrintSecondPart(int n, ref int dashesCount, ref int anpercantsCount, ref string stars, int width)
        {
            stars = "**"; //new string('*', n / 2);
            dashesCount = n / 2;
            var tildasCount = width - (2 * (dashesCount + stars.Length));

            for (int i = n / 2; i > 0; i--)
            {
                Console.Write(new string('-', dashesCount));
                Console.Write(stars);
                Console.Write(new string('~', tildasCount));
                Console.Write(stars);
                Console.WriteLine(new string('-', dashesCount));

                dashesCount++;
                tildasCount -= 2;
            }

            dashesCount = n;
            anpercantsCount = n * 2;
            stars = new string('*', n / 2);

            for (int i = n / 2; i > 0; i--)
            {
                Console.Write(new string('-', dashesCount));
                Console.Write(stars);
                Console.Write(new string('&', anpercantsCount));
                Console.Write(stars);
                Console.WriteLine(new string('-', dashesCount));

                anpercantsCount -= 2;
                stars = stars.Substring(0, stars.Length - 1);
                dashesCount += 2;
            }
        }

        private static void PrintFirstPart(int n, ref int dashesCount, ref int anpercantsCount, ref string stars, int width)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', dashesCount));
                Console.Write(stars);
                Console.Write(new string('&', anpercantsCount));
                Console.Write(stars);
                Console.WriteLine(new string('-', dashesCount));

                anpercantsCount += 2;
                stars += "*";
                dashesCount -= 2;
            }

            stars = "**";
            dashesCount = n - 1;
            var tildasCount = width - (2 * (dashesCount + stars.Length));

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', dashesCount));
                Console.Write(stars);
                Console.Write(new string('~', tildasCount));
                Console.Write(stars);
                Console.WriteLine(new string('-', dashesCount));

                dashesCount--;
                tildasCount += 2;
            }
        }

        private static void PrintFirstOrLastLine(int n)
        {
            Console.Write(new string('-', 2 * n));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}