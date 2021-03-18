using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Partial
{
    // partial 部分类，两部分都要加partial关键字
    public partial class MyForm
    {
        public void ButtonClicked()
        {
            Console.WriteLine("Button '{0}' clicked", this.button);
        }
    }
}
