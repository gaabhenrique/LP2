
namespace Atividade8
{
    partial class frmExercicio1
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
            this.btnProcessDataWhile = new System.Windows.Forms.Button();
            this.btnProcessDataFor = new System.Windows.Forms.Button();
            this.rtextText = new System.Windows.Forms.RichTextBox();
            this.cbR = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnProcessDataWhile
            // 
            this.btnProcessDataWhile.Location = new System.Drawing.Point(362, 205);
            this.btnProcessDataWhile.Name = "btnProcessDataWhile";
            this.btnProcessDataWhile.Size = new System.Drawing.Size(150, 50);
            this.btnProcessDataWhile.TabIndex = 6;
            this.btnProcessDataWhile.Text = "Processar Dados (While)";
            this.btnProcessDataWhile.UseVisualStyleBackColor = true;
            this.btnProcessDataWhile.Click += new System.EventHandler(this.btnProcessDataWhile_Click);
            // 
            // btnProcessDataFor
            // 
            this.btnProcessDataFor.Location = new System.Drawing.Point(12, 205);
            this.btnProcessDataFor.Name = "btnProcessDataFor";
            this.btnProcessDataFor.Size = new System.Drawing.Size(150, 50);
            this.btnProcessDataFor.TabIndex = 5;
            this.btnProcessDataFor.Text = "Processar Dados (For)";
            this.btnProcessDataFor.UseVisualStyleBackColor = true;
            this.btnProcessDataFor.Click += new System.EventHandler(this.btnProcessDataFor_Click);
            // 
            // rtextText
            // 
            this.rtextText.Location = new System.Drawing.Point(12, 12);
            this.rtextText.Name = "rtextText";
            this.rtextText.Size = new System.Drawing.Size(500, 137);
            this.rtextText.TabIndex = 4;
            this.rtextText.Text = "";
            // 
            // cbR
            // 
            this.cbR.AutoSize = true;
            this.cbR.Location = new System.Drawing.Point(13, 156);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(143, 17);
            this.cbR.TabIndex = 7;
            this.cbR.Text = "Considerar R minusculo?";
            this.cbR.UseVisualStyleBackColor = true;
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbR);
            this.Controls.Add(this.btnProcessDataWhile);
            this.Controls.Add(this.btnProcessDataFor);
            this.Controls.Add(this.rtextText);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcessDataWhile;
        private System.Windows.Forms.Button btnProcessDataFor;
        private System.Windows.Forms.RichTextBox rtextText;
        private System.Windows.Forms.CheckBox cbR;
    }
}