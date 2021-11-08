
namespace Atividade8
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.lblProduction = new System.Windows.Forms.Label();
            this.txtProduction = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblGratification = new System.Windows.Forms.Label();
            this.txtGratification = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBruteSalary = new System.Windows.Forms.TextBox();
            this.lblBruteSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(12, 35);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(35, 13);
            this.lblFunction.TabIndex = 10;
            this.lblFunction.Text = "Cargo";
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(82, 32);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(100, 20);
            this.txtFunction.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(12, 61);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(50, 13);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.Text = "Matricula";
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(82, 58);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(100, 20);
            this.txtRegister.TabIndex = 2;
            // 
            // lblProduction
            // 
            this.lblProduction.AutoSize = true;
            this.lblProduction.Location = new System.Drawing.Point(12, 87);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(53, 13);
            this.lblProduction.TabIndex = 14;
            this.lblProduction.Text = "Produção";
            // 
            // txtProduction
            // 
            this.txtProduction.Location = new System.Drawing.Point(82, 84);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(100, 20);
            this.txtProduction.TabIndex = 3;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 113);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 16;
            this.lblSalary.Text = "Salario";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(82, 110);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // lblGratification
            // 
            this.lblGratification.AutoSize = true;
            this.lblGratification.Location = new System.Drawing.Point(12, 139);
            this.lblGratification.Name = "lblGratification";
            this.lblGratification.Size = new System.Drawing.Size(64, 13);
            this.lblGratification.TabIndex = 18;
            this.lblGratification.Text = "Gratificação";
            // 
            // txtGratification
            // 
            this.txtGratification.Location = new System.Drawing.Point(82, 136);
            this.txtGratification.Name = "txtGratification";
            this.txtGratification.Size = new System.Drawing.Size(100, 20);
            this.txtGratification.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 188);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular Salario Bruto";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBruteSalary
            // 
            this.txtBruteSalary.Location = new System.Drawing.Point(82, 162);
            this.txtBruteSalary.Name = "txtBruteSalary";
            this.txtBruteSalary.ReadOnly = true;
            this.txtBruteSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBruteSalary.TabIndex = 20;
            this.txtBruteSalary.TabStop = false;
            // 
            // lblBruteSalary
            // 
            this.lblBruteSalary.AutoSize = true;
            this.lblBruteSalary.Location = new System.Drawing.Point(12, 165);
            this.lblBruteSalary.Name = "lblBruteSalary";
            this.lblBruteSalary.Size = new System.Drawing.Size(67, 13);
            this.lblBruteSalary.TabIndex = 21;
            this.lblBruteSalary.Text = "Salario Bruto";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBruteSalary);
            this.Controls.Add(this.txtBruteSalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGratification);
            this.Controls.Add(this.txtGratification);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblProduction);
            this.Controls.Add(this.txtProduction);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtRegister;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.TextBox txtProduction;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblGratification;
        private System.Windows.Forms.TextBox txtGratification;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBruteSalary;
        private System.Windows.Forms.Label lblBruteSalary;
    }
}