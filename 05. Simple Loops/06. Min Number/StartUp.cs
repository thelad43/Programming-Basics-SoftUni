namespace _06.MinNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var smallestNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
