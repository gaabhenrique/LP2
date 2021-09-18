
namespace CalculadoraImc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtObesidade = new System.Windows.Forms.TextBox();
            this.lblObesidade = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAltura.Location = new System.Drawing.Point(12, 9);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(75, 18);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura (M)";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(114, 7);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(128, 20);
            this.txtAltura.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(248, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(248, 37);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(114, 38);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(128, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPeso.Location = new System.Drawing.Point(12, 37);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(79, 18);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso (Kg)";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(114, 94);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.ReadOnly = true;
            this.txtClassificacao.Size = new System.Drawing.Size(128, 20);
            this.txtClassificacao.TabIndex = 7;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Arial", 12F);
            this.lblClassificacao.Location = new System.Drawing.Point(12, 94);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(103, 18);
            this.lblClassificacao.TabIndex = 6;
            this.lblClassificacao.Text = "Classificação";
            this.lblClassificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(248, 67);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 79);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtObesidade
            // 
            this.txtObesidade.Location = new System.Drawing.Point(114, 126);
            this.txtObesidade.Name = "txtObesidade";
            this.txtObesidade.ReadOnly = true;
            this.txtObesidade.Size = new System.Drawing.Size(128, 20);
            this.txtObesidade.TabIndex = 10;
            // 
            // lblObesidade
            // 
            this.lblObesidade.AutoSize = true;
            this.lblObesidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblObesidade.Location = new System.Drawing.Point(12, 126);
            this.lblObesidade.Name = "lblObesidade";
            this.lblObesidade.Size = new System.Drawing.Size(86, 18);
            this.lblObesidade.TabIndex = 9;
            this.lblObesidade.Text = "Obesidade";
            this.lblObesidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Arial", 12F);
            this.lblImc.Location = new System.Drawing.Point(12, 66);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(36, 18);
            this.lblImc.TabIndex = 11;
            this.lblImc.Text = "IMC";
            this.lblImc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(115, 66);
            this.txtImc.Name = "txtImc";
            this.txtImc.ReadOnly = true;
            this.txtImc.Size = new System.Drawing.Size(128, 20);
            this.txtImc.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 153);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.txtObesidade);
            this.Controls.Add(this.lblObesidade);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Imc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtObesidade;
        private System.Windows.Forms.Label lblObesidade;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.TextBox txtImc;
    }
}

