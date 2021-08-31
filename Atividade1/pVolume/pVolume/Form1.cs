using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double raio = 0;
            Double altura = 0;

            if ((Double.TryParse(txtAltura.Text, out altura)) && (Double.TryParse(txtRaio.Text, out raio))){
                raio = Double.Parse(txtRaio.Text);
                altura = Double.Parse(txtAltura.Text);
                txtVolume.Text = (Math.PI * Math.Pow(raio, 2) * altura).ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtVolume.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
