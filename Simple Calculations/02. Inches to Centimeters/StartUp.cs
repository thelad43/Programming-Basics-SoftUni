namespace _02.Inches_to_Centimeters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inches = double.Parse(Console.ReadLine());
            Console.WriteLine(inches * 2.54);
        }
    }
}
