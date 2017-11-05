namespace _10.Radians_to_Degrees
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            var degs = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(degs));
        }
    }
}
