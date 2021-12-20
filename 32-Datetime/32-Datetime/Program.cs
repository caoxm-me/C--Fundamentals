using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = DateTime.Now;

            int year = d2.Year;
            int hour = d2.Hour;

            string str = d2.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime d3 = DateTime.ParseExact("2021/12/09", 
                "yyyy/MM/dd", CultureInfo.InvariantCulture);

            DateTime d4 = d3.AddDays(-100);
            Console.WriteLine("100天前：" + d4.ToString("yyyy-MM-dd"));
            TimeSpan ts = d2.Subtract(d1);
            double milli = ts.TotalMilliseconds;
            Console.WriteLine(milli);
        }
    }
}
