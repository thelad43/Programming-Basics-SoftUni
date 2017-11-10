namespace _07.Christmas_Tree
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stars = "*";

            Console.WriteLine(new string(' ', n + 1) + "|");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - 1 - i) + stars + " | " + stars);
                stars += "*";
            }
        }
    }
}
