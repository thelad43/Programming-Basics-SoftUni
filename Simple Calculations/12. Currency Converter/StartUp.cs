namespace _12.Currency_Converter
{
    using System;

    public class StartUp
    {
        private const double Usd = 1.79549;
        private const double Eur = 1.95583;
        private const double Gbp = 2.53405;

        public static void Main()
        {
            var amount = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "USD")
            {
                if (to == "EUR")
                {
                    Console.WriteLine("{0:F2}", (amount * Usd) / Eur);
                }
                else if (to == "GBP")
                {
                    Console.WriteLine("{0:F2}", (amount * Gbp) / Eur);
                }
                else if (to == "BGN")
                {
                    Console.WriteLine("{0:F2}", amount * Usd);
                }
                else
                {
                    Console.WriteLine(amount);
                }
            }
            else if (from == "EUR")
            {
                if (to == "BGN")
                {
                    Console.WriteLine("{0:F2}", amount / Eur);
                }
                else if (to == "GBP")
                {
                    Console.WriteLine("{0:F2}", (amount / Gbp) * Eur);
                }
                else if (to == "USD")
                {
                    Console.WriteLine("{0:F2}", (amount / Usd) * Eur);
                }
                else
                {
                    Console.WriteLine(amount);
                }
            }
            else if (from == "GBP")
            {
                if (to == "EUR")
                {
                    Console.WriteLine("{0:F2}", amount * Eur / Gbp);
                }
                else if (to == "USD")
                {
                    Console.WriteLine("{0:F2}", amount * Gbp / Usd);
                }
                else if (to == "BGN")
                {
                    Console.WriteLine("{0:F2}", amount / Gbp);
                }
                else
                {
                    Console.WriteLine(amount);
                }
            }
            else if (from == "BGN")
            {
                if (to == "EUR")
                {
                    Console.WriteLine("{0:F2}", amount / Eur);
                }
                else if (to == "USD")
                {
                    Console.WriteLine("{0:F2}", amount / Usd);
                }
                else if (to == "GBP")
                {
                    Console.WriteLine("{0:F2}", amount / Gbp);
                }
                else
                {
                    Console.WriteLine(amount);
                }
            }
        }
    }
}
