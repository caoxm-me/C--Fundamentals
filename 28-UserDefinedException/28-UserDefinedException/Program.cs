using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_UserDefinedException
{
    class Program
    {
        static void check(int num)
        {
            if (num < 0 || num > 100)
            {
                throw new InvalidException("数据范围不合理");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                check(-1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
