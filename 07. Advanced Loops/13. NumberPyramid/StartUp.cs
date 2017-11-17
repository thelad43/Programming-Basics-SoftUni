namespace _13.NumberPyramid
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;
            var counter = 1;

            while (number <= n)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.Write(number + " ");
                    number++;

                    if (number > n)
                    {
                        return;
                    }
                }

                counter++;
                Console.WriteLine();
            }
        }
    }
}
