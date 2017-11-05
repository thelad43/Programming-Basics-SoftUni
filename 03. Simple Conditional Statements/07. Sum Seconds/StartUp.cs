namespace _07.Sum_Seconds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstTimeInSeconds = int.Parse(Console.ReadLine());
            var secondTimeInSeconds = int.Parse(Console.ReadLine());
            var thirdTimeInSeconds = int.Parse(Console.ReadLine());

            var sum = new DateTime();

            sum = sum.AddSeconds(firstTimeInSeconds);
            sum = sum.AddSeconds(secondTimeInSeconds);
            sum = sum.AddSeconds(thirdTimeInSeconds);

            Console.WriteLine(sum.ToString("m:ss"));
        }
    }
}
