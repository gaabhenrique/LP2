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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int position = txtWord2.Text.IndexOf(txtWord1.Text);

            while (position >= 0)
            {
                txtWord2.Text = txtWord2.Text.Substring(0, position) +
                    txtWord2.Text.Substring(position + txtWord1.Text.Length, txtWord2.Text.Length - position - txtWord1.Text.Length);

                position = txtWord2.Text.IndexOf(txtWord1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtWord2.Text.Replace(txtWord1.Text, "");
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            char[] vector = txtWord1.Text.ToCharArray();

            Array.Reverse(vector);

            txtWord2.Clear();

            foreach(char c in vector)
            {
                txtWord2.Text += c;
            }
        }
    }
}
