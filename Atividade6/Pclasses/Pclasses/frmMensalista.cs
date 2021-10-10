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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstatiate_Click(object sender, EventArgs e)
        {
            Mensalista mensalistaObject = new Mensalista();
            mensalistaObject.RegistrationNumber = Convert.ToInt32(txtRegister.Text);
            mensalistaObject.EmployedName = txtName.Text;
            mensalistaObject.TeamJoinTime = Convert.ToDateTime(txtTJoin.Text);
            mensalistaObject.MonthilySalary = Convert.ToDouble(txtMSalary.Text);

            //get
            MessageBox.Show("Matricula: " + mensalistaObject.RegistrationNumber + "\n" + "Nome: " + mensalistaObject.EmployedName + "\n" + "Data de entrada: " + mensalistaObject.TeamJoinTime + "\n" + "Salário bruto: " + mensalistaObject.GrossSalary() + "\n" + "Tempo de trabalho: " + mensalistaObject.TimeWorked()); ;
        }

        private void btnIWParameters_Click(object sender, EventArgs e)
        {
            Mensalista mensalistaObject = new Mensalista(Convert.ToInt32(txtRegister.Text), txtName.Text, Convert.ToDateTime(txtTJoin.Text), Convert.ToDouble(txtMSalary));
            MessageBox.Show("Matricula: " + mensalistaObject.RegistrationNumber + "\n" + "Nome: " + mensalistaObject.EmployedName + "\n" + "Data de entrada: " + mensalistaObject.TeamJoinTime + "\n" + "Salário bruto: " + mensalistaObject.GrossSalary() + "\n" + "Tempo de trabalho: " + mensalistaObject.TimeWorked()); ;

        }
    }
}
