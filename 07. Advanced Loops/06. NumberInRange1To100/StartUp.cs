namespace _06.NumberInRange1To100
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            var n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 100)
            {
                Console.WriteLine($"The number is: {n}");
            }
            else
            {
                do
                {
                    Console.Write("Еnter a number in the range [1...100]: ");
                    n = int.Parse(Console.ReadLine());

                    if (n >= 1 && n <= 100)
                    {
                        Console.WriteLine($"The number is: {n}");
                        return;
                    }

                } while (true);
            }
        }
    }
}
