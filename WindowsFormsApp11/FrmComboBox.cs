using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEstado.SelectedIndex == 0)
            {
                cbbCidade.Items.Clear();
                cbbCidade.Items.Add("Suzano");
                cbbCidade.Items.Add("São Bernardo");
                cbbCidade.Items.Add("Campinas");
            }

            else if (cbbEstado.SelectedIndex == 1)
            {
                cbbCidade.Items.Clear();
                cbbCidade.Items.Add("Niterói");
                cbbCidade.Items.Add("São Gonçalo");
                cbbCidade.Items.Add("Nova Iguaçu");
            }
            else if (cbbEstado.SelectedIndex == 2)
            {
                cbbCidade.Items.Clear();
                cbbCidade.Items.Add("Belo Horizonte");
                cbbCidade.Items.Add("Ouro Preto");
                cbbCidade.Items.Add("Dimantina");
            }
            else if (cbbCidade.SelectedIndex == 3)
            {
                cbbCidade.Items.Clear();
                cbbCidade.Items.Add("Campina Grande");
                cbbCidade.Items.Add("João Pessoa");
                cbbCidade.Items.Add("Patos");
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Estado Escolhido: {cbbEstado.SelectedItem}, Cidade: {cbbCidade.SelectedItem}");
        }
    }
}
