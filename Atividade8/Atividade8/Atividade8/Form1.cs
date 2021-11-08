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
    public partial class frmPrincipal : Form
    {
        frmExercicio1 frm1;
        frmExercicio2 frm2;
        frmExercicio3 frm3;
        frmExercicio4 frm4;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm1 == null)
            {
                frm1 = new frmExercicio1();
            }

            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void tsmiExercicio2_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new frmExercicio2();
            }

            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void tsmiExercicio3_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new frmExercicio3();
            }

            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm4 == null)
            {
                frm4 = new frmExercicio4();
            }

            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }
    }
}
