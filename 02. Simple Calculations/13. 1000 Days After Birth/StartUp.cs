namespace _13._1000_Days_After_Birth
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
