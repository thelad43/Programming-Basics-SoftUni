namespace RectangleOf10X10Stars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
