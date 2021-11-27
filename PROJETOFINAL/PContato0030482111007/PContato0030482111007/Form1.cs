using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PContato0030482111007
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        private frmContato frmContact = null;

        private void cadastroContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmContact == null)
            {
                frmContact = new frmContato();
            }

            frmContact.MdiParent = this;
            frmContact.WindowState = FormWindowState.Maximized;
            frmContact.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depende da sua máquina da escola ou particular
                conexao = new SqlConnection(Data Source = SlashPc; Initial Catalog = LP2; Integrated Security = True);
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
    }
}
}
