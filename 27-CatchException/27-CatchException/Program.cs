using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_CatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32("miaomiaomiao");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
