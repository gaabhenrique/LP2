
namespace Atividade8
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
            this.txtValorN = new System.Windows.Forms.TextBox();
            this.lblValorN = new System.Windows.Forms.Label();
            this.lblValorH = new System.Windows.Forms.Label();
            this.txtValorH = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorN
            // 
            this.txtValorN.Location = new System.Drawing.Point(60, 6);
            this.txtValorN.Name = "txtValorN";
            this.txtValorN.Size = new System.Drawing.Size(100, 20);
            this.txtValorN.TabIndex = 0;
            // 
            // lblValorN
            // 
            this.lblValorN.AutoSize = true;
            this.lblValorN.Location = new System.Drawing.Point(12, 9);
            this.lblValorN.Name = "lblValorN";
            this.lblValorN.Size = new System.Drawing.Size(42, 13);
            this.lblValorN.TabIndex = 1;
            this.lblValorN.Text = "Valor N";
            // 
            // lblValorH
            // 
            this.lblValorH.AutoSize = true;
            this.lblValorH.Location = new System.Drawing.Point(12, 35);
            this.lblValorH.Name = "lblValorH";
            this.lblValorH.Size = new System.Drawing.Size(42, 13);
            this.lblValorH.TabIndex = 3;
            this.lblValorH.Text = "Valor H";
            // 
            // txtValorH
            // 
            this.txtValorH.Location = new System.Drawing.Point(60, 32);
            this.txtValorH.Name = "txtValorH";
            this.txtValorH.ReadOnly = true;
            this.txtValorH.Size = new System.Drawing.Size(100, 20);
            this.txtValorH.TabIndex = 2;
            this.txtValorH.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 58);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblValorH);
            this.Controls.Add(this.txtValorH);
            this.Controls.Add(this.lblValorN);
            this.Controls.Add(this.txtValorN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorN;
        private System.Windows.Forms.Label lblValorN;
        private System.Windows.Forms.Label lblValorH;
        private System.Windows.Forms.TextBox txtValorH;
        private System.Windows.Forms.Button btnCalculate;
    }
}