namespace _10.Animal_Type
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var animial = Console.ReadLine();

            if (animial == "crocodile" || animial == "tortoise" || animial == "snake")
            {
                Console.WriteLine("reptile");
            }
            else if (animial == "dog")
            {
                Console.WriteLine("mammal");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
