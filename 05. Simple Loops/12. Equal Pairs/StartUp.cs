namespace _12.EqualPairs
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[2 * n];
            var firstSum = 0;
            var secondSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            if (n == 1 && arr[0] == arr[1])
            {
                Console.WriteLine("Yes, value={0}", arr[0] * 2);
            }
            else
            {
                for (int i = 0; i < arr.Length - 3; i++)
                {
                    firstSum = arr[i] + arr[i + 1];
                    secondSum = arr[i + 2] + arr[i + 3];
                }

                if (firstSum == secondSum)
                {
                    Console.WriteLine("Yes value={0}", firstSum);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", Math.Abs(firstSum - secondSum));
                }
            }
        }
    }
}
