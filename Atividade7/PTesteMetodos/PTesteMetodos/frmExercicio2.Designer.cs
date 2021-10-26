
namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.lblWord1 = new System.Windows.Forms.Label();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.txtWord2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnInsertWord = new System.Windows.Forms.Button();
            this.btnInsertSymbol = new System.Windows.Forms.Button();
            this.cbSensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblWord1
            // 
            this.lblWord1.AutoSize = true;
            this.lblWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWord1.Location = new System.Drawing.Point(12, 21);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(74, 20);
            this.lblWord1.TabIndex = 0;
            this.lblWord1.Text = "Palavra 1";
            // 
            // lblWord2
            // 
            this.lblWord2.AutoSize = true;
            this.lblWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWord2.Location = new System.Drawing.Point(12, 68);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(74, 20);
            this.lblWord2.TabIndex = 1;
            this.lblWord2.Text = "Palavra 2";
            // 
            // txtWord1
            // 
            this.txtWord1.Location = new System.Drawing.Point(145, 21);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(175, 20);
            this.txtWord1.TabIndex = 0;
            // 
            // txtWord2
            // 
            this.txtWord2.Location = new System.Drawing.Point(145, 70);
            this.txtWord2.Name = "txtWord2";
            this.txtWord2.Size = new System.Drawing.Size(175, 20);
            this.txtWord2.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCompare.Location = new System.Drawing.Point(11, 132);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(100, 70);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Comparar";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnInsertWord
            // 
            this.btnInsertWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInsertWord.Location = new System.Drawing.Point(145, 132);
            this.btnInsertWord.Name = "btnInsertWord";
            this.btnInsertWord.Size = new System.Drawing.Size(100, 70);
            this.btnInsertWord.TabIndex = 4;
            this.btnInsertWord.Text = "Inserir 1º palavra no meio da 2º";
            this.btnInsertWord.UseVisualStyleBackColor = true;
            this.btnInsertWord.Click += new System.EventHandler(this.btnInsertWord_Click);
            // 
            // btnInsertSymbol
            // 
            this.btnInsertSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInsertSymbol.Location = new System.Drawing.Point(274, 132);
            this.btnInsertSymbol.Name = "btnInsertSymbol";
            this.btnInsertSymbol.Size = new System.Drawing.Size(100, 70);
            this.btnInsertSymbol.TabIndex = 5;
            this.btnInsertSymbol.Text = "Inserir ** no meio da 1º palavra";
            this.btnInsertSymbol.UseVisualStyleBackColor = true;
            this.btnInsertSymbol.Click += new System.EventHandler(this.btnInsertSymbol_Click);
            // 
            // cbSensitive
            // 
            this.cbSensitive.AutoSize = true;
            this.cbSensitive.Location = new System.Drawing.Point(16, 208);
            this.cbSensitive.Name = "cbSensitive";
            this.cbSensitive.Size = new System.Drawing.Size(236, 17);
            this.cbSensitive.TabIndex = 3;
            this.cbSensitive.Text = "Diferenciar letras maiusculas de minusculas?";
            this.cbSensitive.UseVisualStyleBackColor = true;
            this.cbSensitive.CheckedChanged += new System.EventHandler(this.cbSensitive_CheckedChanged);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSensitive);
            this.Controls.Add(this.btnInsertSymbol);
            this.Controls.Add(this.btnInsertWord);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtWord2);
            this.Controls.Add(this.txtWord1);
            this.Controls.Add(this.lblWord2);
            this.Controls.Add(this.lblWord1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord1;
        private System.Windows.Forms.Label lblWord2;
        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.TextBox txtWord2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnInsertWord;
        private System.Windows.Forms.Button btnInsertSymbol;
        private System.Windows.Forms.CheckBox cbSensitive;
    }
}