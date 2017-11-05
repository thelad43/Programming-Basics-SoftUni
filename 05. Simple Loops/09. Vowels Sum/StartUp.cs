namespace _09.VowelsSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var allLeters = Console.ReadLine().ToCharArray();
            var sum = 0;

            foreach (var letter in allLeters)
            {
                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
