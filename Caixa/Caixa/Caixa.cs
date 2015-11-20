using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void definePreco_Click(object sender, EventArgs e)
        {
            if (precoGasolina.Text.Length > 0)
            {
                //using (var context = new SchoolDBEntities())
                using (var context = new productionEntities)
                {
                    Preco novoPreco = new Preco();
                    novoPreco.valor = Convert.ToDecimal(precoGasolina.Text);
                    novoPreco.data = (new DateTime()).ToShortDateString();

                    context.SaveChanges();
                }
                
            }
        }
    }
}
