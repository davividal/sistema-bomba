using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomba
{
    public partial class Bomba : Form
    {
        public Bomba()
        {
            InitializeComponent();
        }

        private void litros_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                // altera valor
            }
        }

        private void valor_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                // altera quantidade de litros
            }
        }
    }
}
