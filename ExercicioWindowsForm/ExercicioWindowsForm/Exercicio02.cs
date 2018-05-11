using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioWindowsForm
{
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btnQuantidadeLitros_Click(object sender, EventArgs e)
        {
            try
            {
            int quantidadeLitros = Convert.ToInt32(txtQuantidadeLitros.Text);
            int quantidadeAnos = Convert.ToInt32(txtQuantidadeAnosConsumidos.Text);
            MessageBox.Show("Quantidade de litros Consumidos " + (quantidadeAnos * 365 * quantidadeLitros));
            }

            catch
            {

            }       
            
        }

        private void btnValorTotal_Click(object sender, EventArgs e)
        {
            double valorLitro = Convert.ToDouble(mtbValor.Text);
            int quantidadeAnos = Convert.ToInt32(txtQuantidadeAnosConsumidos.Text);
            double quantidadeLitros = Convert.ToDouble(txtQuantidadeLitros.Text);
            MessageBox.Show("Valor total pago " + (valorLitro * quantidadeAnos * quantidadeLitros * 365));
        }





    }
}
