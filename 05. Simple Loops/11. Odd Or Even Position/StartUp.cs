namespace _11.OddEvenPosition
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!(i % 2 == 1))
                {
                    oddSum += numbers[i];

                    if (numbers[i] < oddMin)
                    {
                        oddMin = numbers[i];
                    }

                    if (numbers[i] > oddMax)
                    {
                        oddMax = numbers[i];
                    }
                }
                else
                {
                    evenSum += numbers[i];

                    if (numbers[i] < evenMin)
                    {
                        evenMin = numbers[i];
                    }

                    if (numbers[i] > evenMax)
                    {
                        evenMax = numbers[i];
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum}");

            if (oddMin < int.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin}");
            }
            else
            {
                Console.WriteLine($"OddMin=No");
            }

            if (oddMax > int.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax}");
            }
            else
            {
                Console.WriteLine($"OddMax=No");
            }

            Console.WriteLine($"EvenSum={evenSum}");

            if (evenMin != int.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin}");
            }
            else
            {
                Console.WriteLine($"EvenMin=No");
            }

            if (evenMax != int.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else
            {
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
