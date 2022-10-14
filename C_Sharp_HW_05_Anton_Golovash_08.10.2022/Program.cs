using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_HW_05_Library_Anton_Golovash_08._10._2022;

namespace C_Sharp_HW_05_Anton_Golovash_08._10._2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1.Parse("56 84");
            Console.ReadLine();
            //Complex z = new Complex(1, 1);
            //Complex z1;
            //z1 = z - (z * z * z - 1) / (3 * z * z);
            //Console.WriteLine("z1 = {0}", z1);

            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;


        }
    }
}
