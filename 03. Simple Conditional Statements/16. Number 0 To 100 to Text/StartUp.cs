﻿namespace Number_0_To_100_To_Text
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var uniqueNumbers = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
                {10, "ten"},
                {11, "eleven"},
                {12, "twelve"},
                {13, "thirteen"},
                {15, "fifteen"},
                {20, "twenty"},
                {30, "thirty"},
                {50, "fifty"},
                {80, "eighty"},
                {100, "one hundred"}
            };

            var num = int.Parse(Console.ReadLine());
            string result = "";

            if (num >= 0 && num <= 9)
            {
                result = uniqueNumbers[num];
            }
            else if (num >= 10 && num <= 19)
            {
                if (uniqueNumbers.ContainsKey(num))
                {
                    result = uniqueNumbers[num];
                }
                else
                {
                    result = uniqueNumbers[num % 10] + "teen";
                }
            }
            else if (num >= 20 && num <= 100)
            {
                var ones = num % 10;
                var tens = num - ones;
                if (uniqueNumbers.ContainsKey(tens) && ones != 0)
                {
                    result = uniqueNumbers[tens] + " " + uniqueNumbers[ones];
                }
                else if (uniqueNumbers.ContainsKey(tens) && ones == 0)
                {
                    result = uniqueNumbers[tens];
                }
                else if (ones != 0)
                {
                    if (uniqueNumbers[num / 10] == "four")
                    {
                        result = "forty " + uniqueNumbers[ones];
                    }
                    else
                    {
                        result = uniqueNumbers[num / 10] + "ty " + uniqueNumbers[ones];
                    }
                }
                else
                {
                    result = uniqueNumbers[num / 10] + "ty";
                }

            }
            else
            {
                result = "invalid number";
            }

            Console.WriteLine(result);
        }
    }
}
