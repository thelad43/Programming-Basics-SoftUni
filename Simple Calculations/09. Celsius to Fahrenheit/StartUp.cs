namespace _09.Celsius_to_Fahrenheit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
