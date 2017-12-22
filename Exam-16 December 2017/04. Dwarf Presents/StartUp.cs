namespace _04.Dwarf_Presents
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var dwarfsCount = int.Parse(Console.ReadLine());
            var money = decimal.Parse(Console.ReadLine());
            var neededMoney = 0M;

            string currentPresent;
            for (int i = 0; i < dwarfsCount; i++)
            {
                currentPresent = Console.ReadLine();
                switch (currentPresent)
                {
                    case "sand clock":
                        neededMoney += 2.20M;
                        break;

                    case "t-shirt":
                        neededMoney += 10;
                        break;

                    case "magnet":
                        neededMoney += 1.5M;
                        break;

                    case "cup":
                        neededMoney += 5;
                        break;

                    default:
                        throw new Exception();
                }
            }

            if (money >= neededMoney)
            {
                Console.WriteLine($"Santa Claus has {(money - neededMoney):F2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {Math.Abs(money - neededMoney):F2} more leva.");
            }
        }
    }
}