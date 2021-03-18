using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Partial
{
    public partial class MyForm
    {
        public string button = "MyButton";

        public void UserPressButton()
        {
            this.ButtonClicked();
        }
    }
}
