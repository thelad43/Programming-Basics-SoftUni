namespace _05.MaxNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var biggestNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > biggestNum)
                {
                    biggestNum = currentNumber;
                }
            }

            Console.WriteLine(biggestNum);
        }
    }
}
