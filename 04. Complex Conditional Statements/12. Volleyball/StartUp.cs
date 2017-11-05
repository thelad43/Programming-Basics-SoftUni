namespace _12.Volleyball
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var isLeapOrNot = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var weekendsTravelToBornTown = int.Parse(Console.ReadLine());

            var yearWeekends = 48;
            var nonWork = 3d / 4d;
            var daysOfHoliday = 2d / 3d;
            var percanteges = 15d;

            var weekendsInSofia = (double)yearWeekends - weekendsTravelToBornTown;
            weekendsInSofia *= nonWork;
            holidays *= daysOfHoliday;
            var all = weekendsInSofia + holidays + weekendsTravelToBornTown;
            var result = 0d;

            if (isLeapOrNot == "leap")
            {
                result = percanteges * all / 100d;
                result += all;
                Console.WriteLine(Math.Floor(result));
            }
            else
            {
                Console.WriteLine(Math.Floor(all));
            }
        }
    }
}
