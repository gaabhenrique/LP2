using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        float numero1 = 0;
        float numero2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if ((float.TryParse(txtNum1.Text, out numero1)) && (float.TryParse(txtNum2.Text, out numero2)))
            {
                txtResultado.Text = (numero1 + numero2).ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtResultado.Clear();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if ((float.TryParse(txtNum1.Text, out numero1)) && (float.TryParse(txtNum2.Text, out numero2)))
            {
                txtResultado.Text = (numero1 - numero2).ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtResultado.Clear();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if ((float.TryParse(txtNum1.Text, out numero1)) && (float.TryParse(txtNum2.Text, out numero2)))
            {
                txtResultado.Text = (numero1 * numero2).ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtResultado.Clear();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if ((float.TryParse(txtNum1.Text, out numero1)) && (float.TryParse(txtNum2.Text, out numero2)))
            {
                txtResultado.Text = (numero1 / numero2).ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtResultado.Clear();
            }
        }
    }
}
