using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OverrideOperator
{
    public class MyFraction
    {
        private int numerator;
        private int denominator;
        public MyFraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static MyFraction operator *(MyFraction a, MyFraction b)
        {
            int num = a.numerator * b.numerator;
            int nom = a.denominator * b.denominator;
            return new MyFraction(num, nom);
        }

        public void Print()
        {
            Console.WriteLine("{0} / {1}", this.numerator, this.denominator);
        }
    }
}
