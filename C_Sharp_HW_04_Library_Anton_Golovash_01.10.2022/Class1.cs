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
            int multiplier = 1;
            int number = 0;
            for (int i = str.Length - 1; i >= 0; --i)
            {
                if (!(0 <= str[i] && str[i] >= 9))
                {
                    multiplier = 1;
                }
                if (0 <= str[i] && str[i] >= 9)
                {
                    number = str[i];
                    number *= multiplier;
                    A += number;
                }
            }

        }

    }
}
