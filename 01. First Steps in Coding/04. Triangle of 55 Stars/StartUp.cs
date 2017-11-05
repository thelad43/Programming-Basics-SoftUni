namespace _04.Triangle_of_55_Stars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
