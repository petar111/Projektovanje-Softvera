using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLogIn
{
    static class Program
    {
        
        public static void Main()
        {
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.ShowDialog();
        }
    }
}
