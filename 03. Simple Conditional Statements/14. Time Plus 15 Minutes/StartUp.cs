namespace _14.Time_Plus_15_Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var afterFifteenMinutes = new DateTime();

            afterFifteenMinutes = afterFifteenMinutes.AddHours(hours);
            afterFifteenMinutes = afterFifteenMinutes.AddMinutes(minutes + 15);

            var result = string.Empty;

            if (afterFifteenMinutes.Minute <= 9)
            {
                result = afterFifteenMinutes.Hour + ":0" + afterFifteenMinutes.Minute;
            }
            else
            {
                result = afterFifteenMinutes.Hour + ":" + afterFifteenMinutes.Minute;
            }

            Console.WriteLine(result);
        }
    }
}
