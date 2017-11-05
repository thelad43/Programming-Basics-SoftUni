namespace _10.HalfSumElement
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num in numbers)
            {
                if (num == (numbers.Sum() - num))
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {numbers.Sum() - num}");
                    return;
                }
            }

            Console.WriteLine("No");
            Console.Write("Diff = ");
            Console.WriteLine($"{Math.Abs(numbers.Max() - (numbers.Sum() - numbers.Max()))}");
        }
    }
}
