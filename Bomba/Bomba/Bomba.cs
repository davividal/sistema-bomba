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

        private void Bomba_Shown(object sender, EventArgs e)
        {
            unidade.SelectedIndex = 0;
            LblLitro.Visible = false;
            LblMoeda.Visible = true;
            LblDescricao.Text = "Valor:";
        }

        private void Bomba_Load(object sender, EventArgs e)
        {

        }

        private void unidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(unidade.SelectedIndex == 0)
            {
                LblLitro.Visible = false;
                LblMoeda.Visible = true;
                LblDescricao.Text = "Valor:";
            }
            else
            {
                LblLitro.Visible = true;
                LblMoeda.Visible = false;
                LblDescricao.Text = "Quantidade:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
