using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_05_Library_Anton_Golovash_08._10._2022
{
    public class Fraction
    {
        double chislitel;
        double znamenatel;
        public Fraction(double a, double b)
        {
            chislitel = a;
            znamenatel = b;
        }
        public static double operator +(Fraction fr1, double fr2)
        {
            return fr1.chislitel / fr1.znamenatel + fr2;
        }
        public static double operator +(Fraction fr1, Fraction fr2)
        {
            return fr1.chislitel / fr1.znamenatel + fr2.chislitel / fr2.znamenatel;
        }
        public static double operator -(Fraction fr1, Fraction fr2)
        {
            return fr1.chislitel / fr1.znamenatel - fr2.chislitel / fr2.znamenatel;
        }
        public static double operator *(Fraction fr1, int fr2)
        {
            return fr1.chislitel / fr1.znamenatel * fr2;
        }
        public static double operator *(int fr1, Fraction fr2)
        {
            return fr1 * (fr2.chislitel / fr2.znamenatel);
        }
        public static double operator *(Fraction fr1, Fraction fr2)
        {
            return (fr1.chislitel / fr1.znamenatel) * (fr2.chislitel / fr2.znamenatel);
        }
        public static double operator /(Fraction fr1, Fraction fr2)
        {
            return (fr1.chislitel / fr1.znamenatel) / (fr2.chislitel / fr2.znamenatel);
        }
        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            if (fr1.chislitel / fr1.znamenatel == fr2.chislitel / fr2.znamenatel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            if (fr1.chislitel / fr1.znamenatel != fr2.chislitel / fr2.znamenatel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Fraction fr1, Fraction fr2)
        {
            if (fr1.chislitel / fr1.znamenatel < fr2.chislitel / fr2.znamenatel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            if (fr1.chislitel / fr1.znamenatel > fr2.chislitel / fr2.znamenatel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
