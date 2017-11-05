namespace _11.Cinema
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var projection = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var money = 0d;

            if (projection == "premiere")
            {
                money = rows * cols * 12;
            }

            else if (projection == "normal")
            {
                money = rows * cols * 7.50;
            }
            else if (projection == "discount")
            {
                money = rows * cols * 5;
            }

            Console.WriteLine("{0:F2} leva", money);
        }
    }
}
