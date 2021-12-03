namespace PCidade
{
    partial class frmContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContato));
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnvContato = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNomeContato = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.Dados = new System.Windows.Forms.TabPage();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.dtpDtCadastroContato = new System.Windows.Forms.DateTimePicker();
            this.lblDtCadastroContato = new System.Windows.Forms.Label();
            this.txtEmailContato = new System.Windows.Forms.TextBox();
            this.lblEmailContato = new System.Windows.Forms.Label();
            this.txtCelContato = new System.Windows.Forms.TextBox();
            this.lblCelContato = new System.Windows.Forms.Label();
            this.txtEndContato = new System.Windows.Forms.TextBox();
            this.lblEndContato = new System.Windows.Forms.Label();
            this.cbxCidadeContato = new System.Windows.Forms.ComboBox();
            this.tbContato = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bnvContato)).BeginInit();
            this.bnvContato.SuspendLayout();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.Detalhes.SuspendLayout();
            this.tbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnAlterar.Text = "Alterar Registro";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(28, 28);
            this.btnSalvar.Text = "Salvar Registros";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.RightToLeftAutoMirrorImage = true;
            this.btnNovoRegistro.Size = new System.Drawing.Size(28, 28);
            this.btnNovoRegistro.Text = "Adicionar Novo Registro";
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveLastItem.Text = "Último Registro";
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveNextItem.Text = "Próximo registro";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMovePreviousItem.Text = "Registro anterior";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveFirstItem.Text = "Primeiro registro";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.BindingNavigatorCountItem.Text = "de {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bnvContato
            // 
            this.bnvContato.AddNewItem = null;
            this.bnvContato.CountItem = this.BindingNavigatorCountItem;
            this.bnvContato.DeleteItem = null;
            this.bnvContato.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnvContato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.btnExcluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnCancelar,
            this.btnSair});
            this.bnvContato.Location = new System.Drawing.Point(0, 0);
            this.bnvContato.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bnvContato.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bnvContato.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bnvContato.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bnvContato.Name = "bnvContato";
            this.bnvContato.PositionItem = this.BindingNavigatorPositionItem;
            this.bnvContato.Size = new System.Drawing.Size(925, 31);
            this.bnvContato.TabIndex = 3;
            this.bnvContato.Text = "bnvCidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(28, 28);
            this.btnCancelar.Text = "Cancelar Alteração";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Enabled = false;
            this.txtNomeContato.Location = new System.Drawing.Point(131, 75);
            this.txtNomeContato.MaxLength = 50;
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(200, 20);
            this.txtNomeContato.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(131, 41);
            this.txtId.MaxLength = 9999;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(25, 148);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNomeContato
            // 
            this.lblNomeContato.AutoSize = true;
            this.lblNomeContato.Location = new System.Drawing.Point(25, 77);
            this.lblNomeContato.Name = "lblNomeContato";
            this.lblNomeContato.Size = new System.Drawing.Size(89, 13);
            this.lblNomeContato.TabIndex = 1;
            this.lblNomeContato.Text = "Nome do contato";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dgvContato);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(906, 467);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToAddRows = false;
            this.dgvContato.AllowUserToDeleteRows = false;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Location = new System.Drawing.Point(9, 6);
            this.dgvContato.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.dgvContato.MinimumSize = new System.Drawing.Size(346, 182);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.Size = new System.Drawing.Size(891, 455);
            this.dgvContato.TabIndex = 0;
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.dtpDtCadastroContato);
            this.Detalhes.Controls.Add(this.lblDtCadastroContato);
            this.Detalhes.Controls.Add(this.txtEmailContato);
            this.Detalhes.Controls.Add(this.lblEmailContato);
            this.Detalhes.Controls.Add(this.txtCelContato);
            this.Detalhes.Controls.Add(this.lblCelContato);
            this.Detalhes.Controls.Add(this.txtEndContato);
            this.Detalhes.Controls.Add(this.lblEndContato);
            this.Detalhes.Controls.Add(this.cbxCidadeContato);
            this.Detalhes.Controls.Add(this.txtNomeContato);
            this.Detalhes.Controls.Add(this.txtId);
            this.Detalhes.Controls.Add(this.lblCidade);
            this.Detalhes.Controls.Add(this.lblNomeContato);
            this.Detalhes.Controls.Add(this.lblId);
            this.Detalhes.Location = new System.Drawing.Point(4, 22);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(906, 467);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            // 
            // dtpDtCadastroContato
            // 
            this.dtpDtCadastroContato.CustomFormat = "dd/MM/yyyy";
            this.dtpDtCadastroContato.Enabled = false;
            this.dtpDtCadastroContato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDtCadastroContato.Location = new System.Drawing.Point(131, 263);
            this.dtpDtCadastroContato.Name = "dtpDtCadastroContato";
            this.dtpDtCadastroContato.Size = new System.Drawing.Size(200, 20);
            this.dtpDtCadastroContato.TabIndex = 11;
            // 
            // lblDtCadastroContato
            // 
            this.lblDtCadastroContato.AutoSize = true;
            this.lblDtCadastroContato.Location = new System.Drawing.Point(25, 263);
            this.lblDtCadastroContato.Name = "lblDtCadastroContato";
            this.lblDtCadastroContato.Size = new System.Drawing.Size(89, 13);
            this.lblDtCadastroContato.TabIndex = 10;
            this.lblDtCadastroContato.Text = "Data do cadastro";
            // 
            // txtEmailContato
            // 
            this.txtEmailContato.Enabled = false;
            this.txtEmailContato.Location = new System.Drawing.Point(131, 220);
            this.txtEmailContato.MaxLength = 100;
            this.txtEmailContato.Name = "txtEmailContato";
            this.txtEmailContato.Size = new System.Drawing.Size(200, 20);
            this.txtEmailContato.TabIndex = 9;
            // 
            // lblEmailContato
            // 
            this.lblEmailContato.AutoSize = true;
            this.lblEmailContato.Location = new System.Drawing.Point(25, 222);
            this.lblEmailContato.Name = "lblEmailContato";
            this.lblEmailContato.Size = new System.Drawing.Size(86, 13);
            this.lblEmailContato.TabIndex = 8;
            this.lblEmailContato.Text = "Email do contato";
            // 
            // txtCelContato
            // 
            this.txtCelContato.Enabled = false;
            this.txtCelContato.Location = new System.Drawing.Point(131, 183);
            this.txtCelContato.MaxLength = 15;
            this.txtCelContato.Name = "txtCelContato";
            this.txtCelContato.Size = new System.Drawing.Size(200, 20);
            this.txtCelContato.TabIndex = 7;
            // 
            // lblCelContato
            // 
            this.lblCelContato.AutoSize = true;
            this.lblCelContato.Location = new System.Drawing.Point(25, 185);
            this.lblCelContato.Name = "lblCelContato";
            this.lblCelContato.Size = new System.Drawing.Size(93, 13);
            this.lblCelContato.TabIndex = 6;
            this.lblCelContato.Text = "Celular do contato";
            // 
            // txtEndContato
            // 
            this.txtEndContato.Enabled = false;
            this.txtEndContato.Location = new System.Drawing.Point(131, 110);
            this.txtEndContato.MaxLength = 100;
            this.txtEndContato.Name = "txtEndContato";
            this.txtEndContato.Size = new System.Drawing.Size(200, 20);
            this.txtEndContato.TabIndex = 5;
            // 
            // lblEndContato
            // 
            this.lblEndContato.AutoSize = true;
            this.lblEndContato.Location = new System.Drawing.Point(25, 112);
            this.lblEndContato.Name = "lblEndContato";
            this.lblEndContato.Size = new System.Drawing.Size(107, 13);
            this.lblEndContato.TabIndex = 4;
            this.lblEndContato.Text = "Endereço do contato";
            // 
            // cbxCidadeContato
            // 
            this.cbxCidadeContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidadeContato.Enabled = false;
            this.cbxCidadeContato.FormattingEnabled = true;
            this.cbxCidadeContato.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxCidadeContato.Location = new System.Drawing.Point(131, 146);
            this.cbxCidadeContato.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCidadeContato.Name = "cbxCidadeContato";
            this.cbxCidadeContato.Size = new System.Drawing.Size(200, 21);
            this.cbxCidadeContato.TabIndex = 3;
            // 
            // tbContato
            // 
            this.tbContato.Controls.Add(this.Dados);
            this.tbContato.Controls.Add(this.Detalhes);
            this.tbContato.Location = new System.Drawing.Point(-1, 51);
            this.tbContato.Name = "tbContato";
            this.tbContato.SelectedIndex = 0;
            this.tbContato.Size = new System.Drawing.Size(914, 493);
            this.tbContato.TabIndex = 2;
            // 
            // frmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 556);
            this.Controls.Add(this.bnvContato);
            this.Controls.Add(this.tbContato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmContato";
            this.Text = "Contato";
            this.Load += new System.EventHandler(this.frmContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvContato)).EndInit();
            this.bnvContato.ResumeLayout(false);
            this.bnvContato.PerformLayout();
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            this.tbContato.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton btnSair;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.ToolStripButton btnNovoRegistro;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.BindingNavigator bnvContato;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.TextBox txtNomeContato;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblCidade;
        internal System.Windows.Forms.Label lblNomeContato;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.TabPage Dados;
        internal System.Windows.Forms.DataGridView dgvContato;
        internal System.Windows.Forms.TabPage Detalhes;
        internal System.Windows.Forms.TabControl tbContato;
        private System.Windows.Forms.ComboBox cbxCidadeContato;
        private System.Windows.Forms.DateTimePicker dtpDtCadastroContato;
        internal System.Windows.Forms.Label lblDtCadastroContato;
        internal System.Windows.Forms.TextBox txtEmailContato;
        internal System.Windows.Forms.Label lblEmailContato;
        internal System.Windows.Forms.TextBox txtCelContato;
        internal System.Windows.Forms.Label lblCelContato;
        internal System.Windows.Forms.TextBox txtEndContato;
        internal System.Windows.Forms.Label lblEndContato;
    }
}