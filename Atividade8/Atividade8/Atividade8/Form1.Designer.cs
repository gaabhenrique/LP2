
namespace Atividade8
{
    partial class frmPrincipal
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
            this.msForm1 = new System.Windows.Forms.MenuStrip();
            this.tsmiExercicio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msForm1
            // 
            this.msForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExercicio1,
            this.tsmiExercicio2,
            this.tsmiExercicio3,
            this.exercicio4ToolStripMenuItem});
            this.msForm1.Location = new System.Drawing.Point(0, 0);
            this.msForm1.Name = "msForm1";
            this.msForm1.Size = new System.Drawing.Size(800, 24);
            this.msForm1.TabIndex = 0;
            this.msForm1.Text = "menuStrip1";
            // 
            // tsmiExercicio1
            // 
            this.tsmiExercicio1.Name = "tsmiExercicio1";
            this.tsmiExercicio1.Size = new System.Drawing.Size(75, 20);
            this.tsmiExercicio1.Text = "Exercicio &1";
            this.tsmiExercicio1.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
            // 
            // tsmiExercicio2
            // 
            this.tsmiExercicio2.Name = "tsmiExercicio2";
            this.tsmiExercicio2.Size = new System.Drawing.Size(75, 20);
            this.tsmiExercicio2.Text = "Exercicio &2";
            this.tsmiExercicio2.Click += new System.EventHandler(this.tsmiExercicio2_Click);
            // 
            // tsmiExercicio3
            // 
            this.tsmiExercicio3.Name = "tsmiExercicio3";
            this.tsmiExercicio3.Size = new System.Drawing.Size(75, 20);
            this.tsmiExercicio3.Text = "Exercicio &3";
            this.tsmiExercicio3.Click += new System.EventHandler(this.tsmiExercicio3_Click);
            // 
            // exercicio4ToolStripMenuItem
            // 
            this.exercicio4ToolStripMenuItem.Name = "exercicio4ToolStripMenuItem";
            this.exercicio4ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercicio4ToolStripMenuItem.Text = "Exercicio &4";
            this.exercicio4ToolStripMenuItem.Click += new System.EventHandler(this.exercicio4ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msForm1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msForm1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.msForm1.ResumeLayout(false);
            this.msForm1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msForm1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio3;
        private System.Windows.Forms.ToolStripMenuItem exercicio4ToolStripMenuItem;
    }
}

