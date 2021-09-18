using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        double valorA;
        double valorB;
        double valorC;

        public Form1()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            txtValorA.Clear();
            txtValorB.Clear();
            txtValorC.Clear();
            txtClassificacao.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtValorA.Text, out valorA)) && (double.TryParse(txtValorB.Text, out valorB)) && (double.TryParse(txtValorC.Text, out valorC)))
            {
                if(((valorB - valorC) < valorA) && ((valorB + valorC) > valorA))
                {
                    txtClassificacao.Text = "Isósceles";
                }
                else if (((valorA - valorC) < valorB) && ((valorA + valorC) > valorB))
                {
                    txtClassificacao.Text = "Equilátero";
                }
                else if (((valorA - valorB) < valorC) && ((valorA + valorB) > valorC))
                {
                    txtClassificacao.Text = "Escaleno";
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos, favor inserir apenas números nas 3 caixas");
                clearAll();
            }
        }
    }
}
