using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PCidade
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        AboutBox1 frmSobre;
        frmContato frmContato;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {// trocar aqui pela sua própria conexao de acordo com a sua maquina
                conexao = new SqlConnection("Data Source=GaabPc;Initial Catalog=LP2;Integrated Security=True");
                
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSobre == null)
            {
                frmSobre = new AboutBox1();
            }
            frmSobre.MdiParent = this;
            frmSobre.WindowState = FormWindowState.Maximized;
            frmSobre.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmContato == null)
            {
                frmContato = new frmContato();
            }
            frmContato.MdiParent = this;
            frmContato.WindowState = FormWindowState.Maximized;
            frmContato.Show();
        }

    }
}
