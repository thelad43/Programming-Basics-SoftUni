namespace _06.Circle_Area_and_Perimeter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            var perimeter = 2 * Math.PI * radius;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
