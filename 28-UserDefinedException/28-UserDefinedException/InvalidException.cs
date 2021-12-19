using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_UserDefinedException
{
    class InvalidException:Exception
    {
        public InvalidException(string message):base(message)
        {

        }
    }
}
