
namespace PTesteMetodos
{
    partial class frmExercicio5
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnSelectRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(97, 12);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(129, 20);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstNumber.Location = new System.Drawing.Point(13, 13);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(78, 20);
            this.lblFirstNumber.TabIndex = 1;
            this.lblFirstNumber.Text = "Numero 1";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSecondNumber.Location = new System.Drawing.Point(13, 39);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(78, 20);
            this.lblSecondNumber.TabIndex = 3;
            this.lblSecondNumber.Text = "Numero 2";
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(97, 38);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(129, 20);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // btnSelectRandom
            // 
            this.btnSelectRandom.Location = new System.Drawing.Point(17, 84);
            this.btnSelectRandom.Name = "btnSelectRandom";
            this.btnSelectRandom.Size = new System.Drawing.Size(209, 40);
            this.btnSelectRandom.TabIndex = 2;
            this.btnSelectRandom.Text = "Sortear Número";
            this.btnSelectRandom.UseVisualStyleBackColor = true;
            this.btnSelectRandom.Click += new System.EventHandler(this.btnSelectRandom_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectRandom);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Button btnSelectRandom;
    }
}