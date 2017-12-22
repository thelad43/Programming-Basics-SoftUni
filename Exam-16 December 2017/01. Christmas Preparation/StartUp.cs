namespace _01.Christmas_Preparation
{
    using System;

    public class StartUp
    {
        private const double WrappingPaperPriceInLevs = 5.80;
        private const double MaterialPriceInLevs = 7.20;
        private const double GluePricePerLiterInLevs = 1.20;

        public static void Main()
        {
            var wrappingPaperRollsCount = int.Parse(Console.ReadLine());
            var materialRollsCount = int.Parse(Console.ReadLine());
            var glueLiters = double.Parse(Console.ReadLine());
            var discountPercentages = int.Parse(Console.ReadLine());

            var priceWrappingPaperRolls = wrappingPaperRollsCount * WrappingPaperPriceInLevs;
            var priceMaterialRolls = materialRollsCount * MaterialPriceInLevs;
            var priceGlue = glueLiters * GluePricePerLiterInLevs;

            var priceForAllMaterials = priceWrappingPaperRolls + priceMaterialRolls + priceGlue;
            var priceWithDiscount = priceForAllMaterials - ((priceForAllMaterials * discountPercentages) / 100);

            Console.WriteLine($"{priceWithDiscount:F3}");
        }
    }
}