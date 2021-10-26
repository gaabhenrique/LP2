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
    public partial class frmExercicio2 : Form
    {
        private bool considerSensitive = false;

        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(String.Compare(txtWord1.Text, txtWord2.Text, considerSensitive) == 0)
            {
                MessageBox.Show("São iguais");
            }
            else
            {
                MessageBox.Show("São diferentes");
            }
        }

        private void cbSensitive_CheckedChanged(object sender, EventArgs e)
        {
                considerSensitive = !cbSensitive.Checked;
        }

        private void btnInsertWord_Click(object sender, EventArgs e)
        {
            int halfWord2 = txtWord2.TextLength / 2;
            txtWord2.Text = txtWord2.Text.Substring(0, halfWord2) +
                txtWord1.Text + txtWord2.Text.Substring(halfWord2, txtWord2.Text.Length - halfWord2);
        }

        private void btnInsertSymbol_Click(object sender, EventArgs e)
        {
            int halfWord1 = txtWord1.TextLength / 2;

            txtWord2.Text = txtWord1.Text.Insert(halfWord1, "**");
        }
    }
}
