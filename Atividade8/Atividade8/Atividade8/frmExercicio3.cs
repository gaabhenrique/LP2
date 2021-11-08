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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            txtWord.Text = txtWord.Text.ToLower();
            char[] wordChars = txtWord.Text.ToCharArray();
            char[] wordCharsReverse = txtWord.Text.ToCharArray();

            Array.Reverse(wordCharsReverse);

            string wordString = "";
            string wordStringReverse = "";

            foreach (char c in wordChars)
            {
                if (Char.IsWhiteSpace(c))
                {

                }
                else
                {
                    wordString += c;
                }
            }

            foreach (char c in wordCharsReverse)
            {
                if (Char.IsWhiteSpace(c))
                {

                }
                else
                {
                    wordStringReverse += c;
                }
            }

            if (String.Compare(wordString, wordStringReverse) == 0)
            {
                MessageBox.Show("A palavra é um palindromo");
            }
            else
            {
                MessageBox.Show("A palavra não é um palindromo");
            }
        }
    }
}
