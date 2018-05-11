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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSucessor_Click(object sender, EventArgs e)
        {
            int sucessor = Convert.ToInt32(txtNumero.Text);
            MessageBox.Show("Número sucessor é " + (sucessor + 1));
        }

        private void btnAntecessor_Click(object sender, EventArgs e)
        {
            int antecessor = Convert.ToInt32(txtNumero.Text);
            MessageBox.Show("Número antecessor é " + (antecessor - 1));
        }


    }
}
