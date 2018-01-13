namespace _07.GreatestCommonDivisor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var oldValue = b;
                b = a % b;
                a = oldValue;
            }

            Console.WriteLine(a);
        }
    }
}
