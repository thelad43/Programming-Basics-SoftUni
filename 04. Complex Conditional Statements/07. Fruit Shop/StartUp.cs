namespace _07.Fruit_Shop
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var amount = double.Parse(Console.ReadLine());
            var result = 0d;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    result = amount * 2.50;
                }
                else if (fruit == "apple")
                {
                    result = amount * 1.20;
                }
                else if (fruit == "orange")
                {
                    result = amount * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    result = amount * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    result = amount * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    result = amount * 5.50;
                }
                else if (fruit == "grapes")
                {
                    result = amount * 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    result = amount * 2.70;
                }
                else if (fruit == "apple")
                {
                    result = amount * 1.25;
                }
                else if (fruit == "orange")
                {
                    result = amount * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    result = amount * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    result = amount * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    result = amount * 5.60;
                }
                else if (fruit == "grapes")
                {
                    result = amount * 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
