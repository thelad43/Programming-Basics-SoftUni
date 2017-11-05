namespace _13.Area_of_Figures
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var figure = Console.ReadLine();
            var result = 0d;

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                result = Math.Round(side * side, 3);
            }
            else if (figure == "rectangle")
            {
                var sideA = double.Parse(Console.ReadLine());
                var sideB = double.Parse(Console.ReadLine());

                result = Math.Round(sideA * sideB, 3);
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                result = Math.Round(Math.PI * radius * radius, 3);
            }
            else if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                result = Math.Round(side * height / 2, 3);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

            Console.WriteLine(result);
        }
    }
}
