using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCidade
{
    public partial class frmContato : Form
    {
        private BindingSource bnContato = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsContato = new DataSet();
        private DataSet dsCidade = new DataSet();

        public frmContato()
        {
            InitializeComponent();
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            try
            {
                Contato Con = new Contato();
                dsContato.Tables.Add(Con.Listar());
                bnContato.DataSource = dsContato.Tables["Contato"];
                dgvContato.DataSource = bnContato;
                bnvContato.BindingSource = bnContato;

                txtId.DataBindings.Add("TEXT", bnContato, "id_contato");
                txtNomeContato.DataBindings.Add("TEXT", bnContato, "nome_contato");
                txtEndContato.DataBindings.Add("TEXT", bnContato, "end_contato");
                cbxCidadeContato.DataBindings.Add("SelectedItem", bnContato, "CIDADE_ID_CIDADE");
                txtCelContato.DataBindings.Add("TEXT", bnContato, "cel_contato");
                txtEmailContato.DataBindings.Add("TEXT", bnContato, "email_contato");
                dtpDtCadastroContato.DataBindings.Add("TEXT", bnContato, "dtcadastro_contato");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidadeContato.DataSource = dsCidade.Tables["CIDADE"];
                cbxCidadeContato.DisplayMember = "nome_cidade";
                cbxCidadeContato.ValueMember = "id_cidade";
                cbxCidadeContato.DataBindings.Add("SelectedValue", bnContato, "cidade_id_cidade");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            bnContato.AddNew();

            txtNomeContato.Enabled = true;
            cbxCidadeContato.Enabled = true;
            cbxCidadeContato.SelectedIndex = 0;
            txtNomeContato.Focus();
            txtEndContato.Enabled = true;
            txtEmailContato.Enabled = true;
            txtCelContato.Enabled = true;
            dtpDtCadastroContato.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }


            if (MessageBox.Show("Deseja excluir?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Contato RegCon = new Contato();

                RegCon.IdContato = Convert.ToInt16(txtId.Text);

                if (RegCon.Excluir() > 0)
                {
                    MessageBox.Show("O contato foi excluído com sucesso!");
                    Contato R = new Contato();
                    dsContato.Tables.Clear();
                    dsContato.Tables.Add(R.Listar());
                    bnContato.DataSource = dsContato.Tables["CONTATO"];
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o contato!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeContato.Text == "")
            {
                MessageBox.Show("O nome do contato é inválido!");
            }
            else if(txtEndContato.Text == "")
            {
                MessageBox.Show("O endereço do contato é inválido!");
            }
            else if (txtEmailContato.Text == "")
            {
                MessageBox.Show("O email do contato é inválido!");
            }
            else if (txtCelContato.Text == "")
            {
                MessageBox.Show("O celular do contato é inválido!");
            }
            else if (cbxCidadeContato.SelectedIndex == -1)
            {
                MessageBox.Show("A cidade do contato é inválido!");
            }
            else
            {
                Contato RegCon = new Contato();

                RegCon.NomeContato = txtNomeContato.Text;
                RegCon.EndContato = txtEndContato.Text;
                RegCon.EmailContato = txtEmailContato.Text;
                RegCon.CelContato = txtCelContato.Text;
                RegCon.DtCadastroContato = dtpDtCadastroContato.Value;
                RegCon.CidadeIdCidade = Convert.ToInt32(cbxCidadeContato.SelectedValue);

                if (bInclusao)
                {
                    if (RegCon.Salvar() > 0)
                    {
                        MessageBox.Show("O contato foi adicionado com sucesso!");
                        txtNomeContato.Enabled = false;
                        cbxCidadeContato.Enabled = false;
                        txtEndContato.Enabled = false;
                        txtEmailContato.Enabled = false;
                        txtCelContato.Enabled = false;
                        dtpDtCadastroContato.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                        bInclusao = true;


                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCon.Listar());
                        bnContato.DataSource = dsCidade.Tables["Contato"];
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao gravar o contato!");
                    }
                }
                else
                {
                    RegCon.IdContato = Convert.ToInt32(txtId.Text);
                    if (RegCon.Alterar() > 0)
                    {
                        MessageBox.Show("O contato foi alterado com sucesso!");

                        txtNomeContato.Enabled = false;
                        cbxCidadeContato.Enabled = false;
                        txtEndContato.Enabled = false;
                        txtEmailContato.Enabled = false;
                        txtCelContato.Enabled = false;
                        dtpDtCadastroContato.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = false;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                        bInclusao = true;


                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCon.Listar());
                        bnContato.DataSource = dsCidade.Tables["Contato"];

                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao alterar o contato!");
                    }

                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            txtNomeContato.Enabled = true;
            cbxCidadeContato.Enabled = true;
            txtNomeContato.Focus();
            txtEndContato.Enabled = true;
            txtEmailContato.Enabled = true;
            txtCelContato.Enabled = true;
            dtpDtCadastroContato.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            bInclusao = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            bnContato.CancelEdit();

            txtNomeContato.Enabled = false;
            cbxCidadeContato.Enabled = false;
            txtEndContato.Enabled = false;
            txtEmailContato.Enabled = false;
            txtCelContato.Enabled = false;
            dtpDtCadastroContato.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
