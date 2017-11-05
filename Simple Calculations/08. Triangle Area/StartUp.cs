namespace _08.Triangle_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", side * height / 2);
        }
    }
}
