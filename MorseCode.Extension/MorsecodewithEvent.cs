using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCode.Extension
{
    public class MorsecodewithEvent
    {
        public string ToWordLineKeyDown(KeyEventArgs e,int unitTime)
        {
            if(e.KeyCode==Keys.A)
            return "u just pressed A";
            return " ";
        }
    }
}
