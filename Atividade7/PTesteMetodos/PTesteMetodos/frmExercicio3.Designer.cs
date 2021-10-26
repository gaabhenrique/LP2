
namespace PTesteMetodos
{
    partial class frmExercicio3
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
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.txtWord2 = new System.Windows.Forms.TextBox();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.lblWord1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInvert
            // 
            this.btnInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInvert.Location = new System.Drawing.Point(274, 120);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(100, 70);
            this.btnInvert.TabIndex = 13;
            this.btnInvert.Text = "Inverte o 1º";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove2.Location = new System.Drawing.Point(145, 120);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(100, 70);
            this.btnRemove2.TabIndex = 12;
            this.btnRemove2.Text = "Remove 1º do 2º (replace)";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove1.Location = new System.Drawing.Point(11, 120);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(100, 70);
            this.btnRemove1.TabIndex = 10;
            this.btnRemove1.Text = "Remove 1º do 2º";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // txtWord2
            // 
            this.txtWord2.Location = new System.Drawing.Point(145, 58);
            this.txtWord2.Name = "txtWord2";
            this.txtWord2.Size = new System.Drawing.Size(175, 20);
            this.txtWord2.TabIndex = 8;
            // 
            // txtWord1
            // 
            this.txtWord1.Location = new System.Drawing.Point(145, 9);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(175, 20);
            this.txtWord1.TabIndex = 6;
            // 
            // lblWord2
            // 
            this.lblWord2.AutoSize = true;
            this.lblWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWord2.Location = new System.Drawing.Point(12, 56);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(74, 20);
            this.lblWord2.TabIndex = 9;
            this.lblWord2.Text = "Palavra 2";
            // 
            // lblWord1
            // 
            this.lblWord1.AutoSize = true;
            this.lblWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWord1.Location = new System.Drawing.Point(12, 9);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(74, 20);
            this.lblWord1.TabIndex = 7;
            this.lblWord1.Text = "Palavra 1";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.txtWord2);
            this.Controls.Add(this.txtWord1);
            this.Controls.Add(this.lblWord2);
            this.Controls.Add(this.lblWord1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.TextBox txtWord2;
        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.Label lblWord2;
        private System.Windows.Forms.Label lblWord1;
    }
}