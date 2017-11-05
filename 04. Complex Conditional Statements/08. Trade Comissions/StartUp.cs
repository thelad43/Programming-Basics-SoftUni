namespace _08.Trade_Comissions
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commision = -1d;

            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500)
                    commision = 0.05;
                else if (sales > 500 && sales <= 1000)
                    commision = 0.07;
                else if (sales > 1000 && sales <= 10000)
                    commision = 0.08;
                else if (sales > 10000)
                    commision = 0.12;
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                    commision = 0.045;
                else if (sales > 500 && sales <= 1000)
                    commision = 0.075;
                else if (sales > 1000 && sales <= 10000)
                    commision = 0.10;
                else if (sales > 10000)
                    commision = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                    commision = 0.055;
                else if (sales > 500 && sales <= 1000)
                    commision = 0.08;
                else if (sales > 1000 && sales <= 10000)
                    commision = 0.12;
                else if (sales > 10000)
                    commision = 0.145;
            }

            if (commision < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f}", commision * sales);
            }
        }
    }
}
