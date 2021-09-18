
namespace Atividade4
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
            this.lblValorA = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorC = new System.Windows.Forms.Label();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorA.Location = new System.Drawing.Point(12, 9);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(58, 18);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A";
            this.lblValorA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(114, 7);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(128, 20);
            this.txtValorA.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(248, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(248, 37);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(114, 38);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(128, 20);
            this.txtValorB.TabIndex = 1;
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorB.Location = new System.Drawing.Point(12, 37);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(59, 18);
            this.lblValorB.TabIndex = 3;
            this.lblValorB.Text = "Valor B";
            this.lblValorB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(114, 94);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.ReadOnly = true;
            this.txtClassificacao.Size = new System.Drawing.Size(128, 20);
            this.txtClassificacao.TabIndex = 7;
            this.txtClassificacao.TabStop = false;
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
            this.btnCalcular.Size = new System.Drawing.Size(85, 47);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorC.Location = new System.Drawing.Point(12, 66);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(60, 18);
            this.lblValorC.TabIndex = 11;
            this.lblValorC.Text = "Valor C";
            this.lblValorC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(115, 66);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(128, 20);
            this.txtValorC.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 132);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValorA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.TextBox txtValorC;
    }
}

