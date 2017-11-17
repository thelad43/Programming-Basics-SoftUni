namespace _05.Sequence2KPlus1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 1; num <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
