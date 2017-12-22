namespace _06.Barcode_Generator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            var forthDigitStart = start % 10;
            var thirdDigitStart = (start / 10) % 10;
            var secondDigitStart = (start / 100) % 10;
            var firstDigitStart = (start / 1000) % 10;

            var forthDigitEnd = end % 10;
            var thirdDigitEnd = (end / 10) % 10;
            var secondDigitEnd = (end / 100) % 10;
            var firstDigitEnd = (end / 1000) % 10;

            for (int i = firstDigitStart; i <= firstDigitEnd; i++)
            {
                for (int j = secondDigitStart; j <= secondDigitEnd; j++)
                {
                    for (int k = thirdDigitStart; k <= thirdDigitEnd; k++)
                    {
                        for (int f = forthDigitStart; f <= forthDigitEnd; f++)
                        {
                            if (i % 2 == 1 && j % 2 == 1 && k % 2 == 1 && f % 2 == 1)
                            {
                                Console.Write($"{i}{j}{k}{f} ");
                            }
                        }
                    }
                }
            }
        }
    }
}