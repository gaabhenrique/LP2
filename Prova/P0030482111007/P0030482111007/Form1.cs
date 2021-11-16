using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030482111007
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            lvContent.View = View.Details;
            lvContent.LabelEdit = true;
            lvContent.AllowColumnReorder = false;
            lvContent.FullRowSelect = true;
            lvContent.MultiSelect = false;
            lvContent.GridLines = true;

            lvContent.Columns.Add("Data", 150, HorizontalAlignment.Left);
            lvContent.Columns.Add("Valor", 150, HorizontalAlignment.Left);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            float[,] data = new float[7, 4];
            string helper;

            lvContent.Items.Clear();

            for(int i = 0; i < data.GetLength(0); i++)
            {
                float monthValue = 0;

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    helper = Interaction.InputBox("Digite o valor referente ao mês " + (i + 1) + " Semana " + (j + 1),
"Entrada de Dados");
                    if(float.TryParse(helper, out data[i, j]))
                    {
                        ListViewItem item = new ListViewItem("Mês " + (i + 1) + " semana " + (j+1));
                        item.SubItems.Add("RS" + data[i, j].ToString("N2"));
                        lvContent.Items.Add(item);
                        monthValue += data[i, j];
                    }
                    else
                    {
                        MessageBox.Show("Digite um valor valido");
                        j--;
                    }
                }

                ListViewItem value = new ListViewItem("--> Total do mês " + i+1);
                value.SubItems.Add("RS" + monthValue.ToString("N2"));
                lvContent.Items.Add(value);
                lvContent.Items.Add(new ListViewItem("---------------------------------------------------------"));

            }
        }
    }
}
