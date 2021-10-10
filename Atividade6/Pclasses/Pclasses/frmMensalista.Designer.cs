
namespace Pclasses
{
    partial class frmMensalista
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTJoin = new System.Windows.Forms.TextBox();
            this.lblTJoin = new System.Windows.Forms.Label();
            this.txtMSalary = new System.Windows.Forms.TextBox();
            this.lblMSalary = new System.Windows.Forms.Label();
            this.btnInstatiate = new System.Windows.Forms.Button();
            this.btnIWParameters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(144, 83);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(50, 13);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Matricula";
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(238, 80);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(180, 20);
            this.txtRegister.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(144, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome";
            // 
            // txtTJoin
            // 
            this.txtTJoin.Location = new System.Drawing.Point(238, 132);
            this.txtTJoin.Name = "txtTJoin";
            this.txtTJoin.Size = new System.Drawing.Size(180, 20);
            this.txtTJoin.TabIndex = 2;
            // 
            // lblTJoin
            // 
            this.lblTJoin.AutoSize = true;
            this.lblTJoin.Location = new System.Drawing.Point(144, 135);
            this.lblTJoin.Name = "lblTJoin";
            this.lblTJoin.Size = new System.Drawing.Size(88, 13);
            this.lblTJoin.TabIndex = 4;
            this.lblTJoin.Text = "Entrada Empresa";
            // 
            // txtMSalary
            // 
            this.txtMSalary.Location = new System.Drawing.Point(238, 161);
            this.txtMSalary.Name = "txtMSalary";
            this.txtMSalary.Size = new System.Drawing.Size(180, 20);
            this.txtMSalary.TabIndex = 3;
            // 
            // lblMSalary
            // 
            this.lblMSalary.AutoSize = true;
            this.lblMSalary.Location = new System.Drawing.Point(144, 161);
            this.lblMSalary.Name = "lblMSalary";
            this.lblMSalary.Size = new System.Drawing.Size(76, 13);
            this.lblMSalary.TabIndex = 6;
            this.lblMSalary.Text = "Sálario Mensal";
            // 
            // btnInstatiate
            // 
            this.btnInstatiate.Location = new System.Drawing.Point(147, 184);
            this.btnInstatiate.Name = "btnInstatiate";
            this.btnInstatiate.Size = new System.Drawing.Size(110, 50);
            this.btnInstatiate.TabIndex = 4;
            this.btnInstatiate.Text = "Instanciar Mensalista";
            this.btnInstatiate.UseVisualStyleBackColor = true;
            this.btnInstatiate.Click += new System.EventHandler(this.btnInstatiate_Click);
            // 
            // btnIWParameters
            // 
            this.btnIWParameters.Location = new System.Drawing.Point(308, 184);
            this.btnIWParameters.Name = "btnIWParameters";
            this.btnIWParameters.Size = new System.Drawing.Size(110, 50);
            this.btnIWParameters.TabIndex = 5;
            this.btnIWParameters.Text = "Instanciar (Com parâmetros)";
            this.btnIWParameters.UseVisualStyleBackColor = true;
            this.btnIWParameters.Click += new System.EventHandler(this.btnIWParameters_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIWParameters);
            this.Controls.Add(this.btnInstatiate);
            this.Controls.Add(this.txtMSalary);
            this.Controls.Add(this.lblMSalary);
            this.Controls.Add(this.txtTJoin);
            this.Controls.Add(this.lblTJoin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.lblRegister);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTJoin;
        private System.Windows.Forms.Label lblTJoin;
        private System.Windows.Forms.TextBox txtMSalary;
        private System.Windows.Forms.Label lblMSalary;
        private System.Windows.Forms.Button btnInstatiate;
        private System.Windows.Forms.Button btnIWParameters;
    }
}