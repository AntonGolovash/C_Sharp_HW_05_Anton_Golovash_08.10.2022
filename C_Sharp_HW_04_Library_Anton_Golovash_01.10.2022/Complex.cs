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
        public static Complex operator -(Complex number1, int number2)
        {
            number1.x -= number2;
            number1.y -= number2;
            return number1;
        }
        public static Complex operator -(Complex number1, Complex number2)
        {
            number1.x -= number2.x;
            number1.y -= number2.y;
            return number1;
        }
        public static Complex operator *(Complex number1, Complex number2)
        {
            Complex complex = new Complex(0, 0);
            complex.x = number1.x * number2.x;
            complex.y = number1.y * number2.y;
            return complex;
        }
        public static Complex operator *(Complex number1, int number2)
        {
            number1.x *= number2;
            number1.y *= number2;
            return number1;
        }
        public static Complex operator *(int number1, Complex number2)
        {
            number2.x *= number1;
            number2.y *= number1;
            return number2;
        }
        public static Complex operator /(Complex number1, Complex number2)
        {
            Complex complex = new Complex(0, 0);
            complex.x = number1.x / number2.x;
            complex.y = number1.y / number2.y;
            return complex;
        }

        override public string ToString()
        {
            string str = $"number1 = {this.x}, number2 = {this.y}";
            return str;
        }
    }
}
