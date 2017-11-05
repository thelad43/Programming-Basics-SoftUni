namespace _08.Metric_Converter
{
    using System;

    public class StartUp
    {
        private static double value;
        private static string input;
        private static string output;

        public static void Main()
        {
            value = double.Parse(Console.ReadLine());

            input = Console.ReadLine();
            value = ConvertToMeters();
            output = Console.ReadLine();
            value = ConvertToWant();
            Console.WriteLine(value + " " + output);
        }

        public static double ConvertToWant()
        {
            switch (output)
            {
                case "mm":
                    return value * 1000;
                case "cm":
                    return value * 100;
                case "mi":
                    return value * 0.000621371192;
                case "m":
                    return value;
                case "in":
                    return value * 39.3700787;
                case "km":
                    return value * 0.001;
                case "ft":
                    return value * 3.2808399;
                case "yd":
                    return value * 1.0936133;

                default:
                    throw new ArgumentException("Argument Exc");
            }
        }

        public static double ConvertToMeters()
        {
            switch (input)
            {
                case "mm":
                    return value / 1000;
                case "cm":
                    return value / 100;
                case "mi":
                    return value / 0.000621371192;
                case "m":
                    return value;
                case "in":
                    return value / 39.3700787;
                case "km":
                    return value / 0.001;
                case "ft":
                    return value / 3.2808399;
                case "yd":
                    return value / 1.0936133;

                default:
                    throw new ArgumentException("Argument Exc");
            }
        }
    }
}