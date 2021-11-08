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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }



        private void btnProcessDataFor_Click(object sender, EventArgs e)
        {
            int whiteSpaceCounter = 0;
            int rCounter = 0;
            int duplicatedLetterCounter = 0;
            char oldLetter = ' ';

            for (int counter = 0; counter < rtextText.Text.Length; counter++)
            {
                if (Char.IsWhiteSpace(rtextText.Text[counter]))
                {
                    whiteSpaceCounter++;
                }

                // 
                if (rtextText.Text[counter].Equals('R') || (rtextText.Text[counter].Equals('r') && cbR.Checked == true))
                {
                    rCounter++;
                }

                if (rtextText.Text[counter].Equals(oldLetter) && !Char.IsWhiteSpace(rtextText.Text[counter]))
                {
                    duplicatedLetterCounter++;
                }

                oldLetter = rtextText.Text[counter];
            }

            MessageBox.Show("A quantidade de espaços em branco é de: " + whiteSpaceCounter.ToString() + "\n" + "A quantidade de R no texto é de: " + rCounter.ToString() + "\n" + "A quantidade de letras duplicadas é de: " + duplicatedLetterCounter.ToString());
        }

        private void btnProcessDataWhile_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int whiteSpaceCounter = 0;
            int rCounter = 0;
            int duplicatedLetterCounter = 0;
            char oldLetter = ' ';

            while (counter < rtextText.Text.Length)
            {
                if (Char.IsWhiteSpace(rtextText.Text[counter]))
                {
                    whiteSpaceCounter++;
                }

                if (rtextText.Text[counter].Equals('R') || (rtextText.Text[counter].Equals('r') && cbR.Checked == true))
                {
                    rCounter++;
                }

                if (rtextText.Text[counter].Equals(oldLetter) && !Char.IsWhiteSpace(rtextText.Text[counter]))
                {
                    duplicatedLetterCounter++;
                }

                oldLetter = rtextText.Text[counter];

                counter++;
            }

            MessageBox.Show("A quantidade de espaços em branco é de: " + whiteSpaceCounter.ToString() + "\n" + "A quantidade de R no texto é de: " + rCounter.ToString() + "\n" + "A quantidade de letras duplicadas é de: " + duplicatedLetterCounter.ToString());
        }
    }
}
