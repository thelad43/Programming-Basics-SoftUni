namespace _07.LeftAndRightSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
