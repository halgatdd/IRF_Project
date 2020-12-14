using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_paa3zx
{
    class Tbs : TextBox
    {
        public Tbs()
        {
            Height = 20;
            Width = 100;
            ReadOnly = true;
            BackColor = Color.Black;
            ForeColor = Color.White;



        }
    }
}
