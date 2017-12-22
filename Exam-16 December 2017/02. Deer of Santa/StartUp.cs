namespace _02.Deer_of_Santa
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var daysSantaDoesntWork = int.Parse(Console.ReadLine());
            var leftFoodInKg = int.Parse(Console.ReadLine());
            var foofPerDayForFirstDeer = double.Parse(Console.ReadLine());
            var foofPerDayForSecondDeer = double.Parse(Console.ReadLine());
            var foofPerDayForThirdDeer = double.Parse(Console.ReadLine());

            var neededFoodForFirstDeer = daysSantaDoesntWork * foofPerDayForFirstDeer;
            var neededFoodForSecondDeer = daysSantaDoesntWork * foofPerDayForSecondDeer;
            var neededFoodForThirdDeer = daysSantaDoesntWork * foofPerDayForThirdDeer;

            var totalFoodInKg = neededFoodForFirstDeer + neededFoodForSecondDeer + neededFoodForThirdDeer;

            if (leftFoodInKg >= totalFoodInKg)
            {
                Console.WriteLine($"{Math.Floor(leftFoodInKg - totalFoodInKg)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodInKg - leftFoodInKg)} more kilos of food are needed.");
            }
        }
    }
}