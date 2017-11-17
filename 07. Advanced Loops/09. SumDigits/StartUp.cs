namespace _09.SumDigits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
