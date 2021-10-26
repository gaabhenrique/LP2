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
    public partial class frmPrincipal : Form
    {
        frmExercicio2 frm2;
        frmExercicio3 frm3;
        frmExercicio4 frm4;
        frmExercicio5 frm5;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no colar");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm2 == null)
            {
                frm2 = new frmExercicio2();
            }

            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new frmExercicio3();
            }

            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frm4 == null)
            {
                frm4 = new frmExercicio4();
            }

            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm5 == null)
            {
                frm5 = new frmExercicio5();
            }

            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }

    }
}
