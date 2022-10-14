using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_05_Library_Anton_Golovash_08._10._2022
{
    public static class Class1
    {
        public static void Parse(string str)
        {
            int A = 0;
            int B = 0;
            int tempNumber = 0;
            int multiplier = 1;
            int number = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ((Char.GetNumericValue(str[i]) < 0 || (Char.GetNumericValue(str[i]) > 9)))
                {
                    multiplier = 1;
                    number = 0;
                    if (B == 0)
                    {
                        B = tempNumber;
                        tempNumber = 0;
                        Console.WriteLine($"B = {B}");
                        continue;
                    }
                    if (B != 0 && A == 0)
                    {
                        A = tempNumber;
                        Console.WriteLine($"A = {A}");
                    }
                    if (B != 0 && A != 0)
                    {
                        break;
                    }
                }
                if (0 <= Char.GetNumericValue(str[i]) && Char.GetNumericValue(str[i]) <= 9)
                {
                    number = str[i] - 48;
                    number *= multiplier;
                    multiplier *= 10;
                    tempNumber += number;
                }
            }
            Console.ReadLine();

        }

    }
}
