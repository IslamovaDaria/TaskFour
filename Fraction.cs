using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    class Fraction
    {
        int numerator;
        int denominator;
        
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public Fraction() // конструктор без параметров
        {
            numerator = 0;
            denominator = 0;
        }
        public Fraction(int n, int d) // конструктор с параметрами
        {
            this.numerator = n;
            this.denominator = d;
        }

        public override string ToString()
        {
            if (denominator == 1)
                return Convert.ToString(numerator);
            else return numerator + "/" + denominator;
        }

        public static Fraction operator +(Fraction X, Fraction Y)
        {
            Fraction res = new Fraction(X.numerator * Y.denominator + X.denominator * Y.numerator, X.denominator + Y.denominator);
            return res;
        }

        public static Fraction operator *(Fraction X, Fraction Y)
        {
            Fraction res = new Fraction(X.numerator * Y.numerator, X.denominator * Y.denominator);
            return res;
        }

        public static Fraction Reduction(Fraction X)
        {
            int nod = NOD(X.numerator, X.denominator);
            if (nod != 0)
            {
                X.numerator /= nod;
                X.denominator /= nod;
            }
            return X;
        }
        public static int NOD(int n, int d)
        {
            int temp;
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (n != 0 && d != 0)
            {
                if (n % d > 0)
                {
                    temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            else return 0;
        }

    }
}
