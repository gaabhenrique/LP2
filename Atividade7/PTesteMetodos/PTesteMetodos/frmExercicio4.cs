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
    public partial class frmExercicio4 : Form
    {
        int counter;

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumCounter_Click(object sender, EventArgs e)
        {
            counter = 0;
            int numCount = 0;

            while (counter < rtextText.Text.Length)
            {
                if (Char.IsNumber(rtextText.Text[counter]))
                {
                    counter++;
                    numCount++;
                }
                else
                {
                    counter++;
                }
            }

            MessageBox.Show("A quantidade de números no texto é de: " + numCount);
        }

        private void btnWhiteSpace_Click(object sender, EventArgs e)
        {
            counter = 0;

            while (counter < rtextText.Text.Length)
            {
                if (Char.IsWhiteSpace(rtextText.Text[counter]))
                {
                    break;
                }

                counter++;
            }

            counter++;

            MessageBox.Show("A posição do primeiro espaço em branco é: " + counter);
        }

        private void btnLetterCounter_Click(object sender, EventArgs e)
        {
            counter = 0;
            int letterCounter = 0;

            while (counter < rtextText.Text.Length)
            {
                if (Char.IsLetter(rtextText.Text[counter]))
                {
                    counter++;
                    letterCounter++;
                }
                else
                {
                    counter++;
                }
            }

            MessageBox.Show("A quantidade de letras no texto é de: " + letterCounter);
        }
    }
}
