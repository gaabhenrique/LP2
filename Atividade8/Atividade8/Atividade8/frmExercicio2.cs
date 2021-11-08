using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtValorH.Clear();

            int valorN = 0;
            float valorH = 0.0f;

            if (int.TryParse(txtValorN.Text, out valorN) && valorN > 0)
            {
                for(int counter = 1; counter <= valorN; counter++)
                {
                    valorH += 1.0f / counter;
                }

                txtValorH.Text = valorH.ToString();
            }
            else
            {
                MessageBox.Show("Verifique os valores digitados, o valor deve ser maior do que zero");
            }
        }
    }
}