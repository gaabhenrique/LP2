
namespace Pclasses
{
    partial class frmHorista
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
            this.btnInstatiate = new System.Windows.Forms.Button();
            this.txtHSalary = new System.Windows.Forms.TextBox();
            this.lblHSalary = new System.Windows.Forms.Label();
            this.txtTJoin = new System.Windows.Forms.TextBox();
            this.lblTJoin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtHWorked = new System.Windows.Forms.TextBox();
            this.lblHWorked = new System.Windows.Forms.Label();
            this.txtDMissed = new System.Windows.Forms.TextBox();
            this.lblDLose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstatiate
            // 
            this.btnInstatiate.Location = new System.Drawing.Point(337, 287);
            this.btnInstatiate.Name = "btnInstatiate";
            this.btnInstatiate.Size = new System.Drawing.Size(110, 50);
            this.btnInstatiate.TabIndex = 6;
            this.btnInstatiate.Text = "Instanciar Horista";
            this.btnInstatiate.UseVisualStyleBackColor = true;
            this.btnInstatiate.Click += new System.EventHandler(this.btnInstatiate_Click);
            // 
            // txtHSalary
            // 
            this.txtHSalary.Location = new System.Drawing.Point(337, 198);
            this.txtHSalary.Name = "txtHSalary";
            this.txtHSalary.Size = new System.Drawing.Size(180, 20);
            this.txtHSalary.TabIndex = 3;
            // 
            // lblHSalary
            // 
            this.lblHSalary.AutoSize = true;
            this.lblHSalary.Location = new System.Drawing.Point(243, 198);
            this.lblHSalary.Name = "lblHSalary";
            this.lblHSalary.Size = new System.Drawing.Size(65, 13);
            this.lblHSalary.TabIndex = 16;
            this.lblHSalary.Text = "Sálario Hora";
            // 
            // txtTJoin
            // 
            this.txtTJoin.Location = new System.Drawing.Point(337, 169);
            this.txtTJoin.Name = "txtTJoin";
            this.txtTJoin.Size = new System.Drawing.Size(180, 20);
            this.txtTJoin.TabIndex = 2;
            // 
            // lblTJoin
            // 
            this.lblTJoin.AutoSize = true;
            this.lblTJoin.Location = new System.Drawing.Point(243, 172);
            this.lblTJoin.Name = "lblTJoin";
            this.lblTJoin.Size = new System.Drawing.Size(88, 13);
            this.lblTJoin.TabIndex = 14;
            this.lblTJoin.Text = "Entrada Empresa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(337, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(243, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Nome";
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(337, 117);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(180, 20);
            this.txtRegister.TabIndex = 0;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(243, 120);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(50, 13);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.Text = "Matricula";
            // 
            // txtHWorked
            // 
            this.txtHWorked.Location = new System.Drawing.Point(337, 224);
            this.txtHWorked.Name = "txtHWorked";
            this.txtHWorked.Size = new System.Drawing.Size(180, 20);
            this.txtHWorked.TabIndex = 4;
            // 
            // lblHWorked
            // 
            this.lblHWorked.AutoSize = true;
            this.lblHWorked.Location = new System.Drawing.Point(243, 224);
            this.lblHWorked.Name = "lblHWorked";
            this.lblHWorked.Size = new System.Drawing.Size(97, 13);
            this.lblHWorked.TabIndex = 19;
            this.lblHWorked.Text = "Horas Trabalhadas";
            // 
            // txtDMissed
            // 
            this.txtDMissed.Location = new System.Drawing.Point(337, 250);
            this.txtDMissed.Name = "txtDMissed";
            this.txtDMissed.Size = new System.Drawing.Size(180, 20);
            this.txtDMissed.TabIndex = 5;
            // 
            // lblDLose
            // 
            this.lblDLose.AutoSize = true;
            this.lblDLose.Location = new System.Drawing.Point(243, 250);
            this.lblDLose.Name = "lblDLose";
            this.lblDLose.Size = new System.Drawing.Size(66, 13);
            this.lblDLose.TabIndex = 21;
            this.lblDLose.Text = "Dias de falta";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDMissed);
            this.Controls.Add(this.lblDLose);
            this.Controls.Add(this.txtHWorked);
            this.Controls.Add(this.lblHWorked);
            this.Controls.Add(this.btnInstatiate);
            this.Controls.Add(this.txtHSalary);
            this.Controls.Add(this.lblHSalary);
            this.Controls.Add(this.txtTJoin);
            this.Controls.Add(this.lblTJoin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.lblRegister);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstatiate;
        private System.Windows.Forms.TextBox txtHSalary;
        private System.Windows.Forms.Label lblHSalary;
        private System.Windows.Forms.TextBox txtTJoin;
        private System.Windows.Forms.Label lblTJoin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRegister;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtHWorked;
        private System.Windows.Forms.Label lblHWorked;
        private System.Windows.Forms.TextBox txtDMissed;
        private System.Windows.Forms.Label lblDLose;
    }
}