namespace _10.Number_100_To_200
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            if (num > 200)
            {
                Console.WriteLine("Greater than {0}", 200);
            }
            else if (num < 100)
            {
                Console.WriteLine("Less than {0}", 100);
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
