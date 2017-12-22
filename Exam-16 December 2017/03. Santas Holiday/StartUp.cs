namespace _03.Santas_Holiday
{
    using System;

    public class StartUp
    {
        private const decimal PricePerDayForRoomWithOnePerson = 18.00M;
        private const decimal PricePerDayForApartment = 25.00M;
        private const decimal PricePerDayForPresidentApartment = 35.00M;

        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var typeDwelling = Console.ReadLine();
            var rating = Console.ReadLine();
            decimal price;

            switch (typeDwelling)
            {
                case "room for one person":
                    price = (days - 1) * PricePerDayForRoomWithOnePerson;
                    break;

                case "apartment":
                    price = (days - 1) * PricePerDayForApartment;

                    if (days < 10)
                    {
                        price = price - 0.3M * price;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = price - 0.35M * price;
                    }
                    else
                    {
                        price = price - 0.5M * price;
                    }
                    break;

                case "president apartment":
                    price = (days - 1) * PricePerDayForPresidentApartment;
                    //price = (days - 1) * PricePerDayForApartment;

                    if (days < 10)
                    {
                        price = price - 0.1M * price;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = price - 0.15M * price;
                    }
                    else
                    {
                        price = price - 0.2M * price;
                    }
                    break;

                default:
                    throw new Exception();
            }

            if(rating == "positive")
            {
                price = price + 0.25M * price;
            }
            else
            {
                price = price - 0.1M * price;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}