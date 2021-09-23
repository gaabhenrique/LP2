using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraImc
{
    public partial class Form1 : Form
    {
        double altura;
        double peso;
        double imc;

        public Form1()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtImc.Clear();
            txtClassificacao.Clear();
            txtObesidade.Clear();
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
            if ((double.TryParse(txtAltura.Text, out altura)) && (double.TryParse(txtPeso.Text, out peso)))
            {
                if(altura > 0 && peso > 0)
                {
                    imc = peso / Math.Pow(altura, 2);

                    txtImc.Text = imc.ToString("N2");

                    if (imc < 18.5)
                    {
                        txtClassificacao.Text = "Magreza";
                        txtObesidade.Text = "0";
                    }
                    else if (imc < 24.9)
                    {
                        txtClassificacao.Text = "Normal";
                        txtObesidade.Text = "0";
                    }
                    else if (imc < 29.9)
                    {
                        txtClassificacao.Text = "Sobrepeso";
                        txtObesidade.Text = "1";
                    }
                    else if (imc < 39.9)
                    {
                        txtClassificacao.Text = "Obesidade";
                        txtObesidade.Text = "2";
                    }
                    else
                    {
                        txtClassificacao.Text = "Obesidade Grave";
                        txtObesidade.Text = "3";
                    }
                }
                else
                {
                    MessageBox.Show("Valores inválidos");
                    clearAll();
                }


            }
            else
            {
                MessageBox.Show("Valores inválidos");
                clearAll();
            }
        }
    }
}
