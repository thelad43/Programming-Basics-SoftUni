namespace _06._Bonus_Score
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            if (num <= 100)
            {
                bonusScore = 5;
            }

            if (num > 100 && num <= 1000)
            {
                bonusScore += num * 0.2;
            }
            else if (num > 1000)
            {
                bonusScore += num * 0.1;
            }

            if (num % 2 == 0)
            {
                bonusScore += 1;
            }

            if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(bonusScore + num);
        }
    }
}
