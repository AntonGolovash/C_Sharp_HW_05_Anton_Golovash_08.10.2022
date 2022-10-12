using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_05_Library_Anton_Golovash_08._10._2022
{
    public class Complex
    {
        double x = 0;
        double y = 0;
        public Complex(double number1, double number2)
        {
            x = number1;
            y = number2;
        }
            
        public static Complex operator* (Complex number1, Complex number2)
        {
            return number1;
        }
            
    }
}
