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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int production = 0;
            float salary = 0;
            float bruteSalary = 0;
            float gratification = 0;
            int B = 0, C = 0, D = 0;

            if (int.TryParse(txtProduction.Text, out production) && float.TryParse(txtSalary.Text, out salary) && float.TryParse(txtGratification.Text, out gratification))
            {
                if (production >= 100)
                {
                    B = 1;
                }
                if (production >= 120)
                {
                    C = 1;
                }
                if (production >= 150)
                {
                    D = 1;
                }

                bruteSalary = salary + (salary * (0.05f * B + 0.1f * C + 0.1f * D)) + gratification;

                if (D == 0 && bruteSalary > 7000 && gratification == 0)
                {
                    MessageBox.Show("O salario bruto só pode ser superior a R$7000,00 para funcionarios com mais de 150 de produção");
                    txtBruteSalary.Text = txtSalary.Text;
                    return;
                }
                else
                {
                    txtBruteSalary.Text = bruteSalary.ToString();
                }
            }
        }
    }
}
