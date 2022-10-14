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
        public static Fraction operator +(Fraction fr1, double fr2)
        {
            Fraction fraction = new Fraction(0, 0);
            //fraction.chislitel = fr1.chislitel * fr2.znamenatel + fr2.chislitel * fr1.znamenatel;
            //fraction.znamenatel = fr1.znamenatel * fr2.znamenatel;
            return fraction;
        }
        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            Fraction fraction = new Fraction(0, 0);
            fraction.chislitel = fr1.chislitel * fr2.znamenatel + fr2.chislitel * fr1.znamenatel;
            fraction.znamenatel = fr1.znamenatel * fr2.znamenatel;
            return fraction;
        }
        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            Fraction fraction = new Fraction(0, 0);
            fraction.chislitel = fr1.chislitel * fr2.znamenatel - fr2.chislitel * fr1.znamenatel;
            fraction.znamenatel = fr1.znamenatel * fr2.znamenatel;
            return fraction;
        }
        public static Fraction operator *(Fraction fr1, int number)
        {
            Fraction fraction = new Fraction(fr1.chislitel, fr1.znamenatel);
            fraction.chislitel *= number;
            return fraction;
        }
        public static Fraction operator *(int number, Fraction fr2)
        {
            Fraction fraction = new Fraction(fr2.chislitel, fr2.znamenatel);
            fraction.chislitel *= number;
            return fraction;
        }
        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            Fraction fraction = new Fraction(fr1.chislitel, fr1.znamenatel);
            fr1.chislitel *= fr2.chislitel;
            fr1.znamenatel *= fr2.znamenatel;
            return fraction;
        }
        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            Fraction fraction = new Fraction(fr1.chislitel, fr1.znamenatel);
            fr1.chislitel *= fr2.znamenatel;
            fr1.znamenatel *= fr2.chislitel;
            return fraction;
        }
        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            if (fr1.chislitel / fr2.znamenatel == fr2.chislitel / fr1.znamenatel)
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
            if (fr1.chislitel / fr2.znamenatel != fr2.chislitel / fr1.znamenatel)
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
        public static bool operator true(Fraction fr1)
        {
            if (fr1.chislitel < fr1.znamenatel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Fraction fr1)
        {
            if (fr1.chislitel > fr1.znamenatel)
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
