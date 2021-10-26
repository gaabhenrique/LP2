
namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.rtextText = new System.Windows.Forms.RichTextBox();
            this.btnNumCounter = new System.Windows.Forms.Button();
            this.btnWhiteSpace = new System.Windows.Forms.Button();
            this.btnLetterCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtextText
            // 
            this.rtextText.Location = new System.Drawing.Point(25, 13);
            this.rtextText.Name = "rtextText";
            this.rtextText.Size = new System.Drawing.Size(500, 137);
            this.rtextText.TabIndex = 0;
            this.rtextText.Text = "";
            // 
            // btnNumCounter
            // 
            this.btnNumCounter.Location = new System.Drawing.Point(25, 206);
            this.btnNumCounter.Name = "btnNumCounter";
            this.btnNumCounter.Size = new System.Drawing.Size(150, 50);
            this.btnNumCounter.TabIndex = 1;
            this.btnNumCounter.Text = "Contador de numeros no texto";
            this.btnNumCounter.UseVisualStyleBackColor = true;
            this.btnNumCounter.Click += new System.EventHandler(this.btnNumCounter_Click);
            // 
            // btnWhiteSpace
            // 
            this.btnWhiteSpace.Location = new System.Drawing.Point(201, 206);
            this.btnWhiteSpace.Name = "btnWhiteSpace";
            this.btnWhiteSpace.Size = new System.Drawing.Size(150, 50);
            this.btnWhiteSpace.TabIndex = 2;
            this.btnWhiteSpace.Text = "Primeiro Caracter Branco";
            this.btnWhiteSpace.UseVisualStyleBackColor = true;
            this.btnWhiteSpace.Click += new System.EventHandler(this.btnWhiteSpace_Click);
            // 
            // btnLetterCounter
            // 
            this.btnLetterCounter.Location = new System.Drawing.Point(374, 206);
            this.btnLetterCounter.Name = "btnLetterCounter";
            this.btnLetterCounter.Size = new System.Drawing.Size(150, 50);
            this.btnLetterCounter.TabIndex = 3;
            this.btnLetterCounter.Text = "Contar caracteres alfabeticos";
            this.btnLetterCounter.UseVisualStyleBackColor = true;
            this.btnLetterCounter.Click += new System.EventHandler(this.btnLetterCounter_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetterCounter);
            this.Controls.Add(this.btnWhiteSpace);
            this.Controls.Add(this.btnNumCounter);
            this.Controls.Add(this.rtextText);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtextText;
        private System.Windows.Forms.Button btnNumCounter;
        private System.Windows.Forms.Button btnWhiteSpace;
        private System.Windows.Forms.Button btnLetterCounter;
    }
}