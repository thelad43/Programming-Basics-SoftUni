namespace _11.USD_to_BGN
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var dollar = 1.79549;
            var dollarsToConvert = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", dollarsToConvert * dollar);
        }
    }
}
