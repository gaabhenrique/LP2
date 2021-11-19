using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade09
{
    public partial class Form1 : Form
    {
        frmExercicio1 frm1;
        frmExercicio2 frm2;
        frmExercicio3 frm3;
        frmExercicio4 frm4;
        frmExercicio5 frm5;
        frmExercicio6 frm6;
        frmExercicio7 frm7;

        public Form1()
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

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
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

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm6 == null)
            {
                frm6 = new frmExercicio6();
            }

            frm6.MdiParent = this;
            frm6.WindowState = FormWindowState.Maximized;
            frm6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm7 == null)
            {
                frm7 = new frmExercicio7();
            }

            frm7.MdiParent = this;
            frm7.WindowState = FormWindowState.Maximized;
            frm7.Show();
        }
    }
}
