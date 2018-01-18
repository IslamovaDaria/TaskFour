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
        public void Show() //метод для вывода   
        {
            if (denominator != 0)
            {
                if (this.denominator > 0) Console.WriteLine("{0} + i{1}", numerator, denominator);
                else Console.WriteLine("{0} - i{1}", numerator, Math.Abs(denominator));
            }
            else Console.WriteLine("{0}", numerator);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
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

    }
}
