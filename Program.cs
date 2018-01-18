using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 16;
            int[] arr = new int[size];
            FileStream fs = new FileStream("input.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string buf = sr.ReadLine();
            string[] mas = new string[size];
            mas = buf.Split(' ');
            for (int i = 0; i < mas.Length; i++)
                arr[i] = Convert.ToInt32(mas[i]);
            sr.Close();
            fs.Close();

            Fraction x1 = new Fraction(arr[0], arr[1]);
            Fraction x2 = new Fraction(arr[2], arr[3]);
            Fraction x3 = new Fraction(arr[4], arr[5]);
            Fraction x4 = new Fraction(arr[6], arr[7]);
            Fraction x5 = new Fraction(arr[8], arr[9]);
            Fraction x6 = new Fraction(arr[10], arr[11]);
            Fraction x7 = new Fraction(arr[12], arr[13]);
            Fraction c = new Fraction(arr[14], arr[15]);
        }
    }
}
