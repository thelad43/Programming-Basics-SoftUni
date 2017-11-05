namespace _01.Personal_Titles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (gender == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (gender == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
