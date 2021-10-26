using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSelectRandom_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            if ((int.TryParse(txtFirstNumber.Text, out firstNumber)) && (int.TryParse(txtSecondNumber.Text, out secondNumber)))
            {
                Random random = new Random();
                int sort;
                
                if (firstNumber > secondNumber)
                {
                    sort = random.Next(secondNumber, firstNumber);
                }
                else
                {
                    
                    sort = random.Next(firstNumber, secondNumber);
                }

                MessageBox.Show("O número sorteado foi:" + sort);
            }
            else
            {
                MessageBox.Show("Valores invalidos, por favor digite dois números inteiros");
            }
        }
    }
}
