namespace _04.Fruit_or_Vegetable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input == "banana" ||
                input == "apple" ||
                input == "kiwi" ||
                input == "banana" ||
                input == "cherry" ||
                input == "lemon" ||
                input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (input == "tomato" ||
                input == "cucumber" ||
                input == "pepper" ||
                input == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
