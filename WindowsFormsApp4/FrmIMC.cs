using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = Math.Round(peso / (altura * altura),2);

            if (imc < 16.9)
            {
                MessageBox.Show("Muito abaixo do peso.");
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                MessageBox.Show("Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                MessageBox.Show("IMC normal.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                MessageBox.Show("Você está acima do peso.");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                MessageBox.Show("Obesidade grau I.");
            }
            else if (imc >= 35 && imc <= 40)
            {
                MessageBox.Show("Obesidade grau II.");
            }
            else
            {
                MessageBox.Show("Obesidade grau III.");
            }
            txtIMC.Text = ("O seu IMC é " + imc).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();    
            txtIMC.Clear();
        }
    }
}
