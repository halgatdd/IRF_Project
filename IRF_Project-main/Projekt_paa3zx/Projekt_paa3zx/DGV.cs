using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_paa3zx
{
    class DGV : DataGridView
    {
        public DGV()
        {
            BackgroundColor = Color.White;
            AllowUserToAddRows = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorderStyle = BorderStyle.None;
            RowHeadersVisible = false;
        }
    }
}
