using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstatiate_Click(object sender, EventArgs e)
        {
            Horista horistaObject = new Horista();
            horistaObject.RegistrationNumber = Convert.ToInt32(txtRegister.Text);
            horistaObject.EmployedName = txtName.Text;
            horistaObject.TeamJoinTime = Convert.ToDateTime(txtTJoin.Text);
            horistaObject.HourlySalary = Convert.ToDouble(txtHSalary.Text);
            horistaObject.HourCounter = Convert.ToDouble(txtHWorked.Text);
            horistaObject.MissedDays = Convert.ToInt32(txtDMissed.Text);

            //get
            MessageBox.Show("Matricula: " + horistaObject.RegistrationNumber + "\n" + "Nome: " + horistaObject.EmployedName + "\n" + "Data de entrada: " + horistaObject.TeamJoinTime + "\n" + "Salário bruto: " + horistaObject.GrossSalary() + "\n" + "Tempo de trabalho: " + horistaObject.TimeWorked()); ;
        }
    }
}
