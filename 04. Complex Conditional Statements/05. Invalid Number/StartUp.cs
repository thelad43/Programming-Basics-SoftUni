namespace _05.Invalid_Number
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            if (!((num >= 100 && num <= 200) || num == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
