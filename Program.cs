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

            Fraction[] polynom = new Fraction[7];
            polynom[0] = new Fraction(arr[0], arr[1]);
            polynom[1] = new Fraction(arr[2], arr[3]);
            polynom[2] = new Fraction(arr[4], arr[5]);
            polynom[3] = new Fraction(arr[6], arr[7]);
            polynom[4] = new Fraction(arr[8], arr[9]);
            polynom[5] = new Fraction(arr[10], arr[11]);
            polynom[6] = new Fraction(arr[12], arr[13]);
            Fraction x = new Fraction(arr[14], arr[15]);

            Fraction result = Fraction.Gorner(x, polynom);
            result = Fraction.Reduction(result);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        
    }
}
