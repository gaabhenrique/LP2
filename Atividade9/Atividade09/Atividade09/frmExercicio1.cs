using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade09
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnReverseData_Click(object sender, EventArgs e)
        {
            int[] vector = new int[20];
            string helper;
            string reverse = "";

            for (var i = 0; i < vector.Length; i++)
            {
                helper = Interaction.InputBox("Digite um número, a posição atual é: " + (i + 1),
                    "Entrada de Dados");

                if (!int.TryParse(helper, out vector[i]))
                {
                    MessageBox.Show("número inválido");
                    i--;
                }
                else
                    reverse = vector[i] + "\n" + reverse;
            }

            MessageBox.Show(reverse);

            Array.Reverse(vector);
            helper = "";
            foreach (int value in vector)
                helper += value + "\n"; 
            MessageBox.Show(helper);


            helper = "";
            for (var i = vector.Length - 1; i >= 0; i--)
                helper += vector[i] + "\n";
            MessageBox.Show(helper);
        }
    }
}
