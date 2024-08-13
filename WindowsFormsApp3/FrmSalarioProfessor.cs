using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmSalarioProfessor : Form
    {
        public FrmSalarioProfessor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nivel, aula, salarioSemanal = 0, salarioMensal;
            string nome;

            nome = txtNome.Text;
            nivel = int.Parse(txtNivel.Text);
            aula = int.Parse(txtAula.Text);

            if (nivel == 1)
            {
                salarioSemanal = aula * 12;
            }
            else if (nivel == 2)
            {
                salarioSemanal = aula * 17;
            }
            else if (nivel == 3)
            {
                salarioSemanal = aula * 25;
            }
            else
            {
                MessageBox.Show("Esse nível não existe. Tente inserir 1, 2 ou 3.");
                txtNivel.Clear();
            }

            salarioMensal = salarioSemanal * 4;

            txtSalario.Text = ("O salário mensal de " + nome + " é R$" + salarioMensal).ToString();
        }
    }
}
