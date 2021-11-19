
namespace Atividade09
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
            this.btnReverseData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReverseData
            // 
            this.btnReverseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnReverseData.Location = new System.Drawing.Point(161, 165);
            this.btnReverseData.Name = "btnReverseData";
            this.btnReverseData.Size = new System.Drawing.Size(479, 121);
            this.btnReverseData.TabIndex = 4;
            this.btnReverseData.Text = "Inverter entrada";
            this.btnReverseData.UseVisualStyleBackColor = true;
            this.btnReverseData.Click += new System.EventHandler(this.btnReverseData_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReverseData);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReverseData;
    }
}